using ImageMagick;
using System.Text;
using Tesseract;
using static KindleScreenShotTool.TaskbarProgress;

namespace KindleScreenShotTool
{
    public partial class MainForm : Form
    {
        #region �萔

        /// <summary>
        /// �S�p���l�z��
        /// </summary>
        private readonly string[] FullWidthDigitsAr =
        {
            "�O",
            "�P",
            "�Q",
            "�R",
            "�S",
            "�T",
            "�U",
            "�V",
            "�W",
            "�X"
        };

        /// <summary>
        /// ���ꃊ�X�g
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

        #region �v���p�e�B

        /// <summary>
        /// �X�N���[���V���b�g���W�b�N
        /// </summary>
        private ScreenShotLogic ScreenShotLogic { get; } = new();

        /// <summary>
        /// �^�X�N�o�[�v���O���X
        /// </summary>
        private TaskbarProgress TaskbarProgress { get; } = new();

        #endregion

        #region �R���X�g���N�^

        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            LangComboBox.SelectedIndex = 1;
            ConnectionDirectionComboBox.SelectedIndex = 0;
        }

        #endregion

        #region �X�N���[���V���b�g�C�x���g

        /// <summary>
        /// ���s�{�^����������
        /// </summary>
        /// <param name="sender">�I�u�W�F�N�g</param>
        /// <param name="e">�C�x���g</param>
        private async void ScreenShotExeButton_Click(object sender, EventArgs e)
        {
            try
            {
                ScreenShotExeButton.Enabled = false;

                if (string.IsNullOrEmpty(KindleTitleTextBox.Text))
                {
                    ShowMessage("�G���[", "Kindle�̃^�C�g���������͂ł��B", MessageBoxIcon.Error);
                    return;
                }

                if (!ScreenShotLogic.IsKindleRunning(KindleTitleTextBox.Text))
                {
                    ShowMessage("�G���[", "���͂��ꂽ�^�C�g����Kindle���N�����Ă��܂���B", MessageBoxIcon.Error);
                    return;
                }

                if (Equals(DialogResult.OK, ScreenShotSaveFolderBrowserDialog.ShowDialog(this)))
                {
                    // Kindle�^�C�g����ێ�����B
                    string kindleTitle = KindleTitleTextBox.Text;

                    // �B�e����ێ�����B
                    int captureStartX = (int)CaptureStartXNumericUpDown.Value;
                    int captureStartY = (int)CaptureStartYNumericUpDown.Value;
                    int captureWidth = (int)CaptureWidthNumericUpDown.Value;
                    int captureHeight = (int)CaptureHeightNumericUpDown.Value;

                    // �B�e������ێ�����B
                    int captureCount = (int)CaptureCountNumericUpDown.Value;
                    ulong captureCountULong = (ulong)captureCount;

                    // �t�@�C�����A�Ԍ�����ێ�����B
                    int maxLength = (int)FileNameSerialNumberNumericUpDown.Value;

                    // �B�e�ҋ@���Ԃ�ێ�����B
                    int waitingTime = (int)WaitingTimeNumericUpDown.Value;

                    // Kindle�E�B���h�E���A�N�e�B�u�ɂ���B
                    ScreenShotLogic.ActivateKindleWindow(kindleTitle);

                    // �ۑ��_�C�A���O��������O�ɁA�X�N���[���V���b�g�̎B�e���n�܂邽�߁A�ҋ@������B
                    Thread.Sleep(100);

                    await Task.Run(async () =>
                    {
                        // �^�X�N�o�[�̃v���O���X��Ԃ�ݒ肷��B
                        Invoke(() => TaskbarProgress.SetProgressState(Handle, TaskbarProgressState.Normal));

                        for (int index = 0; index < captureCount; index++)
                        {
                            // ��������ƁA���܂��B�e�o���Ȃ����߁A�ҋ@������B
                            await Task.Delay(waitingTime);

                            // �X�N���[���V���b�g���B�e����B
                            ScreenShotLogic.SaveScreenShot(
                                captureStartX,
                                captureStartY,
                                captureWidth,
                                captureHeight,
                                GetSaveFullPath(ScreenShotSaveFolderBrowserDialog.SelectedPath, index, maxLength));

                            // ���L�[����������B
                            ScreenShotLogic.LeftKeyDown(kindleTitle);

                            // �v���O���X�l��ݒ肷��B
                            Invoke(() => TaskbarProgress.SetProgressValue(Handle, (ulong)(index + 1), captureCountULong));
                        }
                    });

                    // �v���O���X����������B
                    TaskbarProgress.SetProgressState(Handle, TaskbarProgressState.NoProgress);

                    // Kindle�E�B���h�E���A�N�e�B�u�ɂȂ��Ă���̂ŁA���g���A�N�e�B�u�ɂ���B
                    Activate();

                    ShowMessage("�X�N���[���V���b�g�B�e����", "�X�N���[���V���b�g�̎B�e���������܂����B", MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ShowMessage("�G���[", ex.Message, MessageBoxIcon.Error);
            }
            finally
            {
                ScreenShotExeButton.Enabled = true;
            }
        }

        /// <summary>
        /// �e�X�g�B�e�{�^����������
        /// </summary>
        /// <param name="sender">�I�u�W�F�N�g</param>
        /// <param name="e">�C�x���g</param>
        private void TestScreenShotButton_Click(object sender, EventArgs e)
        {
            if (Equals(DialogResult.OK, TestScreenShotSaveFileDialog.ShowDialog(this)))
            {
                // �X�N���[���V���b�g���B�e����B
                ScreenShotLogic.SaveScreenShot(
                    (int)CaptureStartXNumericUpDown.Value,
                    (int)CaptureStartYNumericUpDown.Value,
                    (int)CaptureWidthNumericUpDown.Value,
                    (int)CaptureHeightNumericUpDown.Value,
                    TestScreenShotSaveFileDialog.FileName);

                ShowMessage("�e�X�g�X�N���[���V���b�g�B�e����", "�e�X�g�X�N���[���V���b�g�̎B�e���������܂����B", MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// �^�C�g���擾�{�^����������
        /// </summary>
        /// <param name="sender">�I�u�W�F�N�g</param>
        /// <param name="e">�C�x���g</param>
        private void GetTitleButton_Click(object sender, EventArgs e)
        {
            KindleTitleTextBox.Text = ScreenShotLogic.GetKindleTitle();
        }

        /// <summary>
        /// �t�@�C�����A�Ԍ����j���[�����b�N�A�b�v�_�E���l�ύX����
        /// </summary>
        /// <param name="sender">�I�u�W�F�N�g</param>
        /// <param name="e">�C�x���g</param>
        private void FileNameSerialNumberNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            FileNameSampleLabel.Text = $@"�T���v���t�@�C�����F{new string('0', (int)FileNameSerialNumberNumericUpDown.Value)}.png";
        }

        #endregion

        #region OCR�C�x���g

        /// <summary>
        /// ���s�{�^����������
        /// </summary>
        /// <param name="sender">�I�u�W�F�N�g</param>
        /// <param name="e">�C�x���g</param>
        private void OCRExeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(OCRImageFolderPathTextBox.Text))
                {
                    ShowMessage("�G���[", "�摜�t�H���_�p�X�������͂ł��B", MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(LangFileFolderPathTextBox.Text))
                {
                    ShowMessage("�G���[", "����t�@�C���i�[�t�H���_�p�X�������͂ł��B", MessageBoxIcon.Error);
                    return;
                }

                // �e�t�H���_�p�X�𐳋K�����A�ێ�����B
                string imageFolderPath = NormalizePath(OCRImageFolderPathTextBox.Text);
                string langFileFolderPath = NormalizePath(LangFileFolderPathTextBox.Text);

                if (!Directory.Exists(imageFolderPath))
                {
                    ShowMessage("�G���[", "�摜�t�H���_�p�X�����݂��܂���B", MessageBoxIcon.Error);
                    return;
                }

                if (!Directory.Exists(langFileFolderPath))
                {
                    ShowMessage("�G���[", "����t�@�C���i�[�t�H���_�p�X�����݂��܂���B", MessageBoxIcon.Error);
                    return;
                }

                if (SingleRadioButton.Checked)
                {
                    // �t�H���_�I���_�C�A���O��\������B
                    if (!Equals(DialogResult.OK, OCROutputFolderPathFolderBrowserDialog.ShowDialog(this)))
                    {
                        return;
                    }
                }
                else
                {
                    // �t�@�C���ۑ��_�C�A���O��\������B
                    if (!Equals(DialogResult.OK, OCRTextSaveFileDialog.ShowDialog(this)))
                    {
                        return;
                    }
                }

                // �o�͌`����ێ�����B
                bool outputFormatFlg = SingleRadioButton.Checked;

                // �����ێ�����B
                string lngStr = LangList[LangComboBox.SelectedIndex];

                // png�t�@�C���̃t���p�X�̈ꗗ�����X�g�ɂ���B
                List<string> pngPathList = [.. Directory.GetFiles(imageFolderPath, "*.png").OrderBy(path => Path.GetFileName(path))];

                string maxCount = ConvertNumberWide(pngPathList.Count);

                string outputText = string.Empty;
                int count = 0;

                pngPathList.ForEach(pngPath =>
                {
                    // ���[�v����x�ɁA����������B
                    using var tesseract = new TesseractEngine(langFileFolderPath, lngStr);

                    // �摜��ǂݍ��݁A�e�L�X�g�𒊏o����B
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

                    // �^�C�g���ɏ���������ݒ肷��B
                    Invoke(() => Text = $"���������F{ConvertNumberWide(count)}�^{maxCount}�t�@�C������");
                });

                if (!outputFormatFlg)
                {
                    File.WriteAllText(
                        OCRTextSaveFileDialog.FileName,
                        outputText,
                        Encoding.UTF8);
                }

                ShowMessage("OCR��������", "OCR�������������܂����B", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowMessage("�G���[", ex.Message, MessageBoxIcon.Error);
            }
            finally
            {
                Text = "Kindle�X�N���[���V���b�g�c�[��";
            }
        }

        /// <summary>
        /// �t�H���_�I���{�^����������
        /// </summary>
        /// <param name="sender">�I�u�W�F�N�g</param>
        /// <param name="e">�C�x���g</param>
        private void OCRImageFolderPathSelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog_Show(OCRImageFolderPathFolderBrowserDialog, OCRImageFolderPathTextBox);
        }

        /// <summary>
        /// �t�H���_�I���{�^����������
        /// </summary>
        /// <param name="sender">�I�u�W�F�N�g</param>
        /// <param name="e">�C�x���g</param>
        private void LangFileFolderPathSelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog_Show(LangFileFolderPathFolderBrowserDialog, LangFileFolderPathTextBox);
        }

        #endregion

        #region PDF�C�x���g

        /// <summary>
        /// ���s�{�^����������
        /// </summary>
        /// <param name="sender">�I�u�W�F�N�g</param>
        /// <param name="e">�C�x���g</param>
        private void PDFExeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(PDFImageFolderPathTextBox.Text))
                {
                    ShowMessage("�G���[", "�摜�t�H���_�p�X�������͂ł��B", MessageBoxIcon.Error);
                    return;
                }

                // PDF�摜�t�H���_�p�X���擾����B
                string pdfImageFolderPath = NormalizePath(PDFImageFolderPathTextBox.Text);

                if (!Directory.Exists(pdfImageFolderPath))
                {
                    ShowMessage("�G���[", "�摜�t�H���_�p�X�����݂��܂���B", MessageBoxIcon.Error);
                    return;
                }

                if (Equals(DialogResult.OK, PDFSaveFileDialog.ShowDialog(this)))
                {
                    // �g���q���A�y.png�z�i�啶���E��������킸�j�̃t���p�X���擾���A�������s���B
                    using MagickImageCollection imageCollection = [.. Directory.EnumerateFiles(pdfImageFolderPath, "*.png", SearchOption.TopDirectoryOnly)
                        .Where(path => path.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                        .OrderBy(path => Path.GetFileName(path))
                        .Select(pngPath =>
                        {
                            // �摜��PDF�`���Ƃ��ēǂݍ��݁A�v���t�@�C�����폜����B
                            var img = new MagickImage(pngPath)
                            {
                                Format = MagickFormat.Pdf
                            };
                            img.Strip();
                            return img;
                        })];

                    // �摜�R���N�V�������������X�g���[���ɏ������ށB
                    using MemoryStream memStream = new();
                    imageCollection.Write(memStream);
                    memStream.Position = 0;

                    // PDF�t�@�C���Ƃ��ĕۑ�����B
                    File.WriteAllBytes(PDFSaveFileDialog.FileName, memStream.ToArray());

                    ShowMessage("PDF�쐬����", "PDF�̍쐬���������܂����B", MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ShowMessage("�G���[", ex.Message, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// �t�H���_�I���{�^����������
        /// </summary>
        /// <param name="sender">�I�u�W�F�N�g</param>
        /// <param name="e">�C�x���g</param>
        private void PDFImageFolderPathSelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog_Show(PDFImageFolderPathFolderBrowserDialog, PDFImageFolderPathTextBox);
        }

        #endregion

        #region �摜�A���C�x���g

        /// <summary>
        /// ���s�{�^����������
        /// </summary>
        /// <param name="sender">�I�u�W�F�N�g</param>
        /// <param name="e">�C�x���g</param>
        private void ImageConcatenationExeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ImageConcatenationImageFolderPathTextBox.Text))
                {
                    ShowMessage("�G���[", "�摜�t�H���_�p�X�������͂ł��B", MessageBoxIcon.Error);
                    return;
                }

                // �摜�t�H���_�p�X���擾����B
                string imageFolderPath = NormalizePath(ImageConcatenationImageFolderPathTextBox.Text);

                if (!Directory.Exists(imageFolderPath))
                {
                    ShowMessage("�G���[", "�摜�t�H���_�p�X�����݂��܂���B", MessageBoxIcon.Error);
                    return;
                }

                if (Equals(DialogResult.OK, ConnectionImageSaveFolderBrowserDialog.ShowDialog(this)))
                {
                    // �A���������擾����B
                    int connectionDirection = ConnectionDirectionComboBox.SelectedIndex;

                    // �A�������擾����B
                    int connectionCount = (int)ConnectionCountNumericUpDown.Value;

                    // �t�@�C�����A�Ԍ�����ێ�����B
                    int maxLength = (int)ImageConcatenationFileNameSerialNumberNumericUpDown.Value;

                    // �g���q���A�y.png�z�i�啶���E��������킸�j�̑S�t�@�C�����擾���A���X�g�ɂ���B
                    var pngFileList = Directory.EnumerateFiles(imageFolderPath, "*.png", SearchOption.TopDirectoryOnly)
                        .Where(path => path.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                        .OrderBy(Path.GetFileName)
                        .ToList();

                    string maxCount = ConvertNumberWide(pngFileList.Count);

                    // ���X�g�𕪊�����B
                    string[][] splitArray = pngFileList.Chunk(connectionCount).ToArray();

                    int count = 0;

                    for (int index = 0; index < splitArray.Length; index++)
                    {
                        var pngFilePathAr = splitArray[index];

                        // �A�������𔻒肷��B
                        if (Equals(1, connectionDirection) || Equals(3, connectionDirection))
                        {
                            pngFilePathAr = [.. pngFilePathAr.OrderByDescending(pngFilePath => pngFilePath)];
                        }

                        using MagickImageCollection collection = [.. pngFilePathAr
                            .Select(pngFilePath =>
                            {
                                // �摜��PDF�`���Ƃ��ēǂݍ��݁A�v���t�@�C�����폜����B
                                MagickImage img = new(pngFilePath, MagickFormat.Png);
                                img.Strip();
                                return img;
                            })];

                        // �A�������𔻒肵�A�摜��A�g���A�A���摜��ۑ�����B
                        using var finalImage = (connectionDirection == 0 || connectionDirection == 1)
                            ? collection.AppendVertically() : collection.AppendHorizontally();
                        finalImage.Write(GetSaveFullPath(ConnectionImageSaveFolderBrowserDialog.SelectedPath, index, maxLength));

                        count += collection.Count;

                        // �^�C�g���ɏ���������ݒ肷��B
                        Invoke(() => Text = $"���������F{ConvertNumberWide(count)}�^{maxCount}�t�@�C������");
                    }

                    ShowMessage("�摜�A������", "�摜�̘A�����������܂����B", MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ShowMessage("�G���[", ex.Message, MessageBoxIcon.Error);
            }
            finally
            {
                Text = "Kindle�X�N���[���V���b�g�c�[��";
            }
        }

        /// <summary>
        /// �t�@�C�����A�Ԍ����j���[�����b�N�A�b�v�_�E���l�ύX����
        /// </summary>
        /// <param name="sender">�I�u�W�F�N�g</param>
        /// <param name="e">�C�x���g</param>
        private void ImageConcatenationFileNameSerialNumberNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ImageConcatenationFileNameSampleLabel.Text = $@"�T���v���t�@�C�����F{new string('0', (int)ImageConcatenationFileNameSerialNumberNumericUpDown.Value)}.png";
        }

        /// <summary>
        /// �t�H���_�I���{�^����������
        /// </summary>
        /// <param name="sender">�I�u�W�F�N�g</param>
        /// <param name="e">�C�x���g</param>
        private void ImageConcatenationImageFolderPathSelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog_Show(ConnectionImageSaveFolderBrowserDialog, ImageConcatenationImageFolderPathTextBox);
        }

        #endregion

        #region �w���p�[���\�b�h

        /// <summary>
        /// �t�H���_�I���_�C�A���O�\������
        /// </summary>
        /// <param name="folderBrowserDialog">�t�H���_�I���_�C�A���O</param>
        /// <param name="textbox">�e�L�X�g�{�b�N�X</param>
        private void FolderBrowserDialog_Show(FolderBrowserDialog folderBrowserDialog, TextBox textbox)
        {
            // �p�X�����͂���Ă���ꍇ�́A���̓p�X�������l�ɐݒ肷��B
            // �i�u�����N�⑶�݂��Ȃ��p�X�̏ꍇ�A�f�t�H���g�A�������͑O�ɑI�������p�X���ݒ肳���B�j
            folderBrowserDialog.InitialDirectory = textbox.Text;
            if (Equals(DialogResult.OK, folderBrowserDialog.ShowDialog(this)))
            {
                textbox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        /// <summary>
        /// �p�X���K������
        /// </summary>
        /// <param name="path">�p�X</param>
        /// <returns>���K�����ꂽ�p�X</returns>
        private static string NormalizePath(string path)
        {
            string fullPath = string.Empty;
            if (path.Length <= 3)
            {
                // �h���C�u�����݂̂̏ꍇ
                fullPath = string.Concat(char.ToUpperInvariant(path[0]), path[1..]);
            }
            else
            {
                fullPath = Path.GetFullPath(path);

                // ���[�g�����擾����B�i��FC:\�j
                var root = Path.GetPathRoot(fullPath);

                if (!string.IsNullOrEmpty(root) && Path.IsPathRooted(fullPath))
                {
                    // �h���C�u������啶���ɂ���B
                    fullPath = string.Concat(char.ToUpperInvariant(root[0]), fullPath[1..]);
                }
            }

            // �����́y\�z���폜����B
            return fullPath.TrimEnd('\\');
        }

        /// <summary>
        /// �ۑ��t���p�X�擾����
        /// </summary>
        /// <param name="saveFolderPath">�ۑ��t�H���_�p�X</param>
        /// <param name="setNumber">�ݒ�ԍ�</param>
        /// <param name="maxLength">�ő包��</param>
        /// <returns>�ۑ��t���p�X</returns>
        private string GetSaveFullPath(string saveFolderPath, int setNumber, int maxLength)
        {
            if (setNumber.ToString().Length > maxLength)
            {
                setNumber = int.Parse(new string('9', maxLength));
            }

            return $@"{saveFolderPath}\{setNumber.ToString().PadLeft(maxLength, '0')}.png";
        }

        /// <summary>
        /// ���p���l���S�p���l�ϊ�����
        /// </summary>
        /// <param name="narrowNumber">���p���l</param>
        /// <returns>�ϊ������S�p���l</returns>
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
        /// ���b�Z�[�W�\������
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
