namespace WindowsShutdown.Service
{
    partial class ShutdownService
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.windowsShutdownEventLog = new System.Diagnostics.EventLog();
            this.notifyWindowsShutDown = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.windowsShutdownEventLog)).BeginInit();
            // 
            // notifyWindowsShutDown
            // 
            this.notifyWindowsShutDown.Text = "notifyIcon1";
            this.notifyWindowsShutDown.Visible = true;
            // 
            // ShutdownService
            // 
            this.ServiceName = "Service1";
            ((System.ComponentModel.ISupportInitialize)(this.windowsShutdownEventLog)).EndInit();

        }

        #endregion

        private System.Diagnostics.EventLog windowsShutdownEventLog;
        private System.Windows.Forms.NotifyIcon notifyWindowsShutDown;
    }
}
