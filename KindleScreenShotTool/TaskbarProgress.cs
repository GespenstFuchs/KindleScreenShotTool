using System.Runtime.InteropServices;

namespace KindleScreenShotTool
{
    /// <summary>
    /// タスクバープログレス
    /// </summary>
    internal class TaskbarProgress
    {
        /// <summary>
        /// タスクバープログレス状態
        /// </summary>
        public enum TaskbarProgressState
        {
            /// <summary>
            /// 進捗表示無し
            /// </summary>
            NoProgress = 0,

            /// <summary>
            /// 不確定
            /// </summary>
            Indeterminate = 0x1,

            /// <summary>
            /// 通常
            /// </summary>
            Normal = 0x2,

            /// <summary>
            /// エラー
            /// </summary>
            Error = 0x4,

            /// <summary>
            /// 一時停止
            /// </summary>
            Paused = 0x8
        }

        /// <summary>
        /// ITaskbarList3インターフェース
        /// 
        /// ComImport：COMインターフェイスをインポートする宣言
        /// Guid：対応するCOMインターフェイスのGUID
        /// InterfaceType：インターフェイスの呼び出し規約
        /// </summary>
        [ComImport]
        [Guid("EA1AFB91-9E28-4B86-90E9-9E9F8A5EEFAF")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface ITaskbarList3
        {
            /// <summary>
            /// 初期化処理
            /// </summary>
            void HrInit();

            /// <summary>
            /// タブ追加処理
            /// </summary>
            /// <param name="hwnd">ハンドル</param>
            void AddTab(IntPtr hwnd);

            /// <summary>
            /// タブ削除処理
            /// </summary>
            /// <param name="hwnd">ハンドル</param>
            void DeleteTab(IntPtr hwnd);

            /// <summary>
            /// タブアクティブ処理
            /// </summary>
            /// <param name="hwnd">ハンドル</param>
            void ActivateTab(IntPtr hwnd);

            /// <summary>
            /// 別ウィンドウアクティブ化処理
            /// </summary>
            /// <param name="hwnd">ハンドル</param>
            void SetActiveAlt(IntPtr hwnd);

            /// <summary>
            /// フルスクリーンウィンドウマーク処理
            /// </summary>
            /// <param name="hwnd">ハンドル</param>
            /// <param name="fFullscreen">全画面表示（true：全画面・false：非全画面）</param>
            void MarkFullscreenWindow(IntPtr hwnd, [MarshalAs(UnmanagedType.Bool)] bool fFullscreen);

            /// <summary>
            /// プログレス値設定処理
            /// </summary>
            /// <param name="hwnd">ハンドル</param>
            /// <param name="completed">完了値</param>
            /// <param name="total">全体値</param>
            void SetProgressValue(IntPtr hwnd, ulong completed, ulong total);

            /// <summary>
            /// プログレス状態設定処理
            /// </summary>
            /// <param name="hwnd">ハンドル</param>
            /// <param name="state">状態</param>
            void SetProgressState(IntPtr hwnd, TaskbarProgressState state);
        }

        /// <summary>
        /// CTaskbarList
        /// 
        /// 実体は、Windows側で提供されている。
        /// GUIDは、CLSID_CTaskbarListを表している。
        /// </summary>
        [ComImport]
        [Guid("56FDF344-FD6D-11d0-958A-006097C9A090")]
        private class CTaskbarList { }

        /// <summary>
        /// タスクバー進捗操作用COMインスタンス
        /// </summary>
        private ITaskbarList3 TaskbarInstance { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TaskbarProgress()
        {
            // CTaskbarListのCOMオブジェクトを生成し、ITaskbarList3として使用する。
            TaskbarInstance = (ITaskbarList3)new CTaskbarList();

            // 初期化処理を呼び出す。
            TaskbarInstance.HrInit();
        }

        /// <summary>
        /// プログレス設定処理
        /// </summary>
        /// <param name="hwnd">ハンドル</param>
        /// <param name="state">状態</param>
        public void SetProgressState(IntPtr hwnd, TaskbarProgressState state)
        {
            TaskbarInstance.SetProgressState(hwnd, state);
        }

        /// <summary>
        /// プログレス値設定処理
        /// </summary>
        /// <param name="hwnd">ハンドル</param>
        /// <param name="completedValue">完了値</param>
        /// <param name="totalValue">全体値</param>
        public void SetProgressValue(IntPtr hwnd, ulong completedValue, ulong totalValue)
        {
            TaskbarInstance.SetProgressValue(hwnd, completedValue, totalValue);
        }
    }
}
