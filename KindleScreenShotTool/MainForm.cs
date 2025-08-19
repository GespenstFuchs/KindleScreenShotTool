using ImageMagick;
using System.Text;
using Tesseract;
using static KindleScreenShotTool.TaskbarProgress;

namespace KindleScreenShotTool
{
    public partial class MainForm : Form
    {
        #region 定数

        /// <summary>
        /// 全角数値配列
        /// </summary>
        private readonly string[] FullWidthDigitsAr =
        {
            "０",
            "１",
            "２",
            "３",
            "４",
            "５",
            "６",
            "７",
            "８",
            "９"
        };

        /// <summary>
        /// 言語リスト
        /// </summary>
        private readonly List<string> LangList =
        [
            "jpn",
            "jpn_vert",
            "eng",
            "jpn+eng",
            "jpn_vert+eng"
        ];

        #endregion

        #region プロパティ

        /// <summary>
        /// スクリーンショットロジック
        /// </summary>
        private ScreenShotLogic ScreenShotLogic { get; } = new();

        /// <summary>
        /// タスクバープログレス
        /// </summary>
        private TaskbarProgress TaskbarProgress { get; } = new();

        #endregion

        #region コンストラクタ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            LangComboBox.SelectedIndex = 1;
            ConnectionDirectionComboBox.SelectedIndex = 0;
        }

        #endregion

        #region スクリーンショットイベント

        /// <summary>
        /// 実行ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private async void ScreenShotExeButton_Click(object sender, EventArgs e)
        {
            try
            {
                ScreenShotExeButton.Enabled = false;

                if (string.IsNullOrEmpty(KindleTitleTextBox.Text))
                {
                    ShowMessage("エラー", "Kindleのタイトルが未入力です。", MessageBoxIcon.Error);
                    return;
                }

                if (!ScreenShotLogic.IsKindleRunning(KindleTitleTextBox.Text))
                {
                    ShowMessage("エラー", "入力されたタイトルのKindleが起動していません。", MessageBoxIcon.Error);
                    return;
                }

                if (Equals(DialogResult.OK, ScreenShotSaveFolderBrowserDialog.ShowDialog(this)))
                {
                    // Kindleタイトルを保持する。
                    string kindleTitle = KindleTitleTextBox.Text;

                    // 撮影情報を保持する。
                    int captureStartX = (int)CaptureStartXNumericUpDown.Value;
                    int captureStartY = (int)CaptureStartYNumericUpDown.Value;
                    int captureWidth = (int)CaptureWidthNumericUpDown.Value;
                    int captureHeight = (int)CaptureHeightNumericUpDown.Value;

                    // 撮影枚数を保持する。
                    int captureCount = (int)CaptureCountNumericUpDown.Value;
                    ulong captureCountULong = (ulong)captureCount;

                    // ファイル名連番桁数を保持する。
                    int maxLength = (int)FileNameSerialNumberNumericUpDown.Value;

                    // 撮影待機時間を保持する。
                    int waitingTime = (int)WaitingTimeNumericUpDown.Value;

                    // Kindleウィンドウをアクティブにする。
                    ScreenShotLogic.ActivateKindleWindow(kindleTitle);

                    // 保存ダイアログが消える前に、スクリーンショットの撮影が始まるため、待機させる。
                    Thread.Sleep(100);

                    await Task.Run(async () =>
                    {
                        // タスクバーのプログレス状態を設定する。
                        Invoke(() => TaskbarProgress.SetProgressState(Handle, TaskbarProgressState.Normal));

                        for (int index = 0; index < captureCount; index++)
                        {
                            // 早すぎると、うまく撮影出来ないため、待機させる。
                            await Task.Delay(waitingTime);

                            // スクリーンショットを撮影する。
                            ScreenShotLogic.SaveScreenShot(
                                captureStartX,
                                captureStartY,
                                captureWidth,
                                captureHeight,
                                GetSaveFullPath(ScreenShotSaveFolderBrowserDialog.SelectedPath, index, maxLength));

                            // 左キーを押下する。
                            ScreenShotLogic.LeftKeyDown(kindleTitle);

                            // プログレス値を設定する。
                            Invoke(() => TaskbarProgress.SetProgressValue(Handle, (ulong)(index + 1), captureCountULong));
                        }
                    });

                    // プログレスを消去する。
                    TaskbarProgress.SetProgressState(Handle, TaskbarProgressState.NoProgress);

                    // Kindleウィンドウがアクティブになっているので、自身をアクティブにする。
                    Activate();

                    ShowMessage("スクリーンショット撮影完了", "スクリーンショットの撮影が完了しました。", MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ShowMessage("エラー", ex.Message, MessageBoxIcon.Error);
            }
            finally
            {
                ScreenShotExeButton.Enabled = true;
            }
        }

        /// <summary>
        /// テスト撮影ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void TestScreenShotButton_Click(object sender, EventArgs e)
        {
            if (Equals(DialogResult.OK, TestScreenShotSaveFileDialog.ShowDialog(this)))
            {
                // スクリーンショットを撮影する。
                ScreenShotLogic.SaveScreenShot(
                    (int)CaptureStartXNumericUpDown.Value,
                    (int)CaptureStartYNumericUpDown.Value,
                    (int)CaptureWidthNumericUpDown.Value,
                    (int)CaptureHeightNumericUpDown.Value,
                    TestScreenShotSaveFileDialog.FileName);

                ShowMessage("テストスクリーンショット撮影完了", "テストスクリーンショットの撮影が完了しました。", MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// タイトル取得ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void GetTitleButton_Click(object sender, EventArgs e)
        {
            KindleTitleTextBox.Text = ScreenShotLogic.GetKindleTitle();
        }

        /// <summary>
        /// ファイル名連番桁数ニューメリックアップダウン値変更処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void FileNameSerialNumberNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            FileNameSampleLabel.Text = $@"サンプルファイル名：{new string('0', (int)FileNameSerialNumberNumericUpDown.Value)}.png";
        }

        #endregion

        #region OCRイベント

        /// <summary>
        /// 実行ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void OCRExeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(OCRImageFolderPathTextBox.Text))
                {
                    ShowMessage("エラー", "画像フォルダパスが未入力です。", MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(LangFileFolderPathTextBox.Text))
                {
                    ShowMessage("エラー", "言語ファイル格納フォルダパスが未入力です。", MessageBoxIcon.Error);
                    return;
                }

                // 各フォルダパスを正規化し、保持する。
                string imageFolderPath = NormalizePath(OCRImageFolderPathTextBox.Text);
                string langFileFolderPath = NormalizePath(LangFileFolderPathTextBox.Text);

                if (!Directory.Exists(imageFolderPath))
                {
                    ShowMessage("エラー", "画像フォルダパスが存在しません。", MessageBoxIcon.Error);
                    return;
                }

                if (!Directory.Exists(langFileFolderPath))
                {
                    ShowMessage("エラー", "言語ファイル格納フォルダパスが存在しません。", MessageBoxIcon.Error);
                    return;
                }

                if (SingleRadioButton.Checked)
                {
                    // フォルダ選択ダイアログを表示する。
                    if (!Equals(DialogResult.OK, OCROutputFolderPathFolderBrowserDialog.ShowDialog(this)))
                    {
                        return;
                    }
                }
                else
                {
                    // ファイル保存ダイアログを表示する。
                    if (!Equals(DialogResult.OK, OCRTextSaveFileDialog.ShowDialog(this)))
                    {
                        return;
                    }
                }

                // 出力形式を保持する。
                bool outputFormatFlg = SingleRadioButton.Checked;

                // 言語を保持する。
                string lngStr = LangList[LangComboBox.SelectedIndex];

                // pngファイルのフルパスの一覧をリストにする。
                List<string> pngPathList = [.. Directory.GetFiles(imageFolderPath, "*.png").OrderBy(path => Path.GetFileName(path))];

                string maxCount = ConvertNumberWide(pngPathList.Count);

                string outputText = string.Empty;
                int count = 0;

                pngPathList.ForEach(pngPath =>
                {
                    // ループする度に、初期化する。
                    using var tesseract = new TesseractEngine(langFileFolderPath, lngStr);

                    // 画像を読み込み、テキストを抽出する。
                    using var pix = Pix.LoadFromFile(pngPath);
                    Page page = tesseract.Process(pix);

                    if (outputFormatFlg)
                    {
                        File.WriteAllText(
                            string.Concat(OCROutputFolderPathFolderBrowserDialog.SelectedPath, @"\", Path.GetFileNameWithoutExtension(pngPath), ".txt"),
                            page.GetText(),
                            Encoding.UTF8);
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(outputText))
                        {
                            outputText = page.GetText();
                        }
                        else
                        {
                            outputText = string.Concat(outputText, Environment.NewLine, page.GetText());
                        }
                    }

                    count++;

                    // タイトルに処理件数を設定する。
                    Invoke(() => Text = $"処理件数：{ConvertNumberWide(count)}／{maxCount}ファイル完了");
                });

                if (!outputFormatFlg)
                {
                    File.WriteAllText(
                        OCRTextSaveFileDialog.FileName,
                        outputText,
                        Encoding.UTF8);
                }

                ShowMessage("OCR処理完了", "OCR処理が完了しました。", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowMessage("エラー", ex.Message, MessageBoxIcon.Error);
            }
            finally
            {
                Text = "Kindleスクリーンショットツール";
            }
        }

        /// <summary>
        /// フォルダ選択ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void OCRImageFolderPathSelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog_Show(OCRImageFolderPathFolderBrowserDialog, OCRImageFolderPathTextBox);
        }

        /// <summary>
        /// フォルダ選択ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void LangFileFolderPathSelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog_Show(LangFileFolderPathFolderBrowserDialog, LangFileFolderPathTextBox);
        }

        #endregion

        #region PDFイベント

        /// <summary>
        /// 実行ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void PDFExeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(PDFImageFolderPathTextBox.Text))
                {
                    ShowMessage("エラー", "画像フォルダパスが未入力です。", MessageBoxIcon.Error);
                    return;
                }

                // PDF画像フォルダパスを取得する。
                string pdfImageFolderPath = NormalizePath(PDFImageFolderPathTextBox.Text);

                if (!Directory.Exists(pdfImageFolderPath))
                {
                    ShowMessage("エラー", "画像フォルダパスが存在しません。", MessageBoxIcon.Error);
                    return;
                }

                if (Equals(DialogResult.OK, PDFSaveFileDialog.ShowDialog(this)))
                {
                    // 拡張子が、【.png】（大文字・小文字問わず）のフルパスを取得し、処理を行う。
                    using MagickImageCollection imageCollection = [.. Directory.EnumerateFiles(pdfImageFolderPath, "*.png", SearchOption.TopDirectoryOnly)
                        .Where(path => path.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                        .OrderBy(path => Path.GetFileName(path))
                        .Select(pngPath =>
                        {
                            // 画像をPDF形式として読み込み、プロファイルを削除する。
                            var img = new MagickImage(pngPath)
                            {
                                Format = MagickFormat.Pdf
                            };
                            img.Strip();
                            return img;
                        })];

                    // 画像コレクションをメモリストリームに書き込む。
                    using MemoryStream memStream = new();
                    imageCollection.Write(memStream);
                    memStream.Position = 0;

                    // PDFファイルとして保存する。
                    File.WriteAllBytes(PDFSaveFileDialog.FileName, memStream.ToArray());

                    ShowMessage("PDF作成完了", "PDFの作成が完了しました。", MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ShowMessage("エラー", ex.Message, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// フォルダ選択ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void PDFImageFolderPathSelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog_Show(PDFImageFolderPathFolderBrowserDialog, PDFImageFolderPathTextBox);
        }

        #endregion

        #region 画像連結イベント

        /// <summary>
        /// 実行ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void ImageConcatenationExeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ImageConcatenationImageFolderPathTextBox.Text))
                {
                    ShowMessage("エラー", "画像フォルダパスが未入力です。", MessageBoxIcon.Error);
                    return;
                }

                // 画像フォルダパスを取得する。
                string imageFolderPath = NormalizePath(ImageConcatenationImageFolderPathTextBox.Text);

                if (!Directory.Exists(imageFolderPath))
                {
                    ShowMessage("エラー", "画像フォルダパスが存在しません。", MessageBoxIcon.Error);
                    return;
                }

                if (Equals(DialogResult.OK, ConnectionImageSaveFolderBrowserDialog.ShowDialog(this)))
                {
                    // 連結方向を取得する。
                    int connectionDirection = ConnectionDirectionComboBox.SelectedIndex;

                    // 連結数を取得する。
                    int connectionCount = (int)ConnectionCountNumericUpDown.Value;

                    // ファイル名連番桁数を保持する。
                    int maxLength = (int)ImageConcatenationFileNameSerialNumberNumericUpDown.Value;

                    // 拡張子が、【.png】（大文字・小文字問わず）の全ファイルを取得し、リストにする。
                    var pngFileList = Directory.EnumerateFiles(imageFolderPath, "*.png", SearchOption.TopDirectoryOnly)
                        .Where(path => path.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                        .OrderBy(Path.GetFileName)
                        .ToList();

                    string maxCount = ConvertNumberWide(pngFileList.Count);

                    // リストを分割する。
                    string[][] splitArray = pngFileList.Chunk(connectionCount).ToArray();

                    int count = 0;

                    for (int index = 0; index < splitArray.Length; index++)
                    {
                        var pngFilePathAr = splitArray[index];

                        // 連結方向を判定する。
                        if (Equals(1, connectionDirection) || Equals(3, connectionDirection))
                        {
                            pngFilePathAr = [.. pngFilePathAr.OrderByDescending(pngFilePath => pngFilePath)];
                        }

                        using MagickImageCollection collection = [.. pngFilePathAr
                            .Select(pngFilePath =>
                            {
                                // 画像をPDF形式として読み込み、プロファイルを削除する。
                                MagickImage img = new(pngFilePath, MagickFormat.Png);
                                img.Strip();
                                return img;
                            })];

                        // 連結方向を判定し、画像を連携し、連結画像を保存する。
                        using var finalImage = (connectionDirection == 0 || connectionDirection == 1)
                            ? collection.AppendVertically() : collection.AppendHorizontally();
                        finalImage.Write(GetSaveFullPath(ConnectionImageSaveFolderBrowserDialog.SelectedPath, index, maxLength));

                        count += collection.Count;

                        // タイトルに処理件数を設定する。
                        Invoke(() => Text = $"処理件数：{ConvertNumberWide(count)}／{maxCount}ファイル完了");
                    }

                    ShowMessage("画像連結完了", "画像の連結が完了しました。", MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ShowMessage("エラー", ex.Message, MessageBoxIcon.Error);
            }
            finally
            {
                Text = "Kindleスクリーンショットツール";
            }
        }

        /// <summary>
        /// ファイル名連番桁数ニューメリックアップダウン値変更処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void ImageConcatenationFileNameSerialNumberNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ImageConcatenationFileNameSampleLabel.Text = $@"サンプルファイル名：{new string('0', (int)ImageConcatenationFileNameSerialNumberNumericUpDown.Value)}.png";
        }

        /// <summary>
        /// フォルダ選択ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void ImageConcatenationImageFolderPathSelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog_Show(ConnectionImageSaveFolderBrowserDialog, ImageConcatenationImageFolderPathTextBox);
        }

        #endregion

        #region ヘルパーメソッド

        /// <summary>
        /// フォルダ選択ダイアログ表示処理
        /// </summary>
        /// <param name="folderBrowserDialog">フォルダ選択ダイアログ</param>
        /// <param name="textbox">テキストボックス</param>
        private void FolderBrowserDialog_Show(FolderBrowserDialog folderBrowserDialog, TextBox textbox)
        {
            // パスが入力されている場合は、入力パスを初期値に設定する。
            // （ブランクや存在しないパスの場合、デフォルト、もしくは前に選択したパスが設定される。）
            folderBrowserDialog.InitialDirectory = textbox.Text;
            if (Equals(DialogResult.OK, folderBrowserDialog.ShowDialog(this)))
            {
                textbox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        /// <summary>
        /// パス正規化処理
        /// </summary>
        /// <param name="path">パス</param>
        /// <returns>正規化されたパス</returns>
        private static string NormalizePath(string path)
        {
            string fullPath = string.Empty;
            if (path.Length <= 3)
            {
                // ドライブ文字のみの場合
                fullPath = string.Concat(char.ToUpperInvariant(path[0]), path[1..]);
            }
            else
            {
                fullPath = Path.GetFullPath(path);

                // ルート部を取得する。（例：C:\）
                var root = Path.GetPathRoot(fullPath);

                if (!string.IsNullOrEmpty(root) && Path.IsPathRooted(fullPath))
                {
                    // ドライブ文字を大文字にする。
                    fullPath = string.Concat(char.ToUpperInvariant(root[0]), fullPath[1..]);
                }
            }

            // 末尾の【\】を削除する。
            return fullPath.TrimEnd('\\');
        }

        /// <summary>
        /// 保存フルパス取得処理
        /// </summary>
        /// <param name="saveFolderPath">保存フォルダパス</param>
        /// <param name="setNumber">設定番号</param>
        /// <param name="maxLength">最大桁数</param>
        /// <returns>保存フルパス</returns>
        private string GetSaveFullPath(string saveFolderPath, int setNumber, int maxLength)
        {
            if (setNumber.ToString().Length > maxLength)
            {
                setNumber = int.Parse(new string('9', maxLength));
            }

            return $@"{saveFolderPath}\{setNumber.ToString().PadLeft(maxLength, '0')}.png";
        }

        /// <summary>
        /// 半角数値→全角数値変換処理
        /// </summary>
        /// <param name="narrowNumber">半角数値</param>
        /// <returns>変換した全角数値</returns>
        private string ConvertNumberWide(int narrowNumber)
        {
            var sb = new StringBuilder();
            foreach (char ch in narrowNumber.ToString())
            {
                sb.Append(FullWidthDigitsAr[int.Parse(ch.ToString())]);
            }

            return sb.ToString();
        }

        /// <summary>
        /// メッセージ表示処理
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="icon"></param>
        private void ShowMessage(string title, string message, MessageBoxIcon icon)
        {
            MessageBox.Show(
                this,
                message,
                title,
                MessageBoxButtons.OK,
                icon);
        }

        #endregion
    }
}
