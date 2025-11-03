メモ
◆PageSegModeについて
　Tesseractには複数のPSMモードがあり、それぞれのモードは特定のレイアウトに最適化されている。

・使用例
　Page page = tesseract.Process(pix, PageSegMode.SingleBlock);

・パラメータ
3	PageSegMode.Auto (デフォルト)	標準的なドキュメント。ページ全体にテキストが複数行、複数段落で配置されている場合
6	PageSegMode.SingleBlock	画像全体が一つの均一なテキストブロックである場合。シンプルで連続的な文章に最適
7	PageSegMode.SingleLine	画像が単一のテキスト行で構成されている場合。バナー画像や見出し、キャプションなど
8	PageSegMode.SingleWord	画像が単一の単語のみを含む場合。ロゴやラベルなど
11	PageSegMode.SparseText	テキストが画像全体にばらばらに散在している場合。フォームやレシートなど
13	PageSegMode.RawLine	テキスト行の歪み補正を行わずにOCRを実行する場合

・Tesseractの言語ファイル
https://github.com/tesseract-ocr/tessdata


◆ビルド時に、
【ファイル MainForm.resx を処理できませんでした。インターネットまたは制限付きゾーン内にあるか、ファイルに Web のマークがあるためです。これらのファイルを処理するには、Web のマークを削除してください。】
というエラーが出た場合の対処法

（以下、Windowsのエクスプローラーからの操作）
１．MainForm.resxを右クリックして「プロパティ」を開く。
２．「全般」タブの下部に「セキュリティ」セクションが表示されている場合
　　「このファイルは他のコンピューターから取得したものです。コンピューターを保護するため、このファイルへのアクセスが制限されている可能性があります。」チェックボックスのチェックを外す。
３．「適用」→「OK」で閉じる。
４．Visual Studioの方で、再度ビルドする。
