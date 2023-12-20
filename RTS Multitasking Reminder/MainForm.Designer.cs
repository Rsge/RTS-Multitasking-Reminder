namespace RTSMultitaskingReminder {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            CountdownTxt = new TextBox();
            StartStopButton = new Button();
            CycleLabel = new Label();
            CycleNUD = new NumericUpDown();
            UnitLabel = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)CycleNUD).BeginInit();
            SuspendLayout();
            // 
            // CountdownTxt
            // 
            resources.ApplyResources(CountdownTxt, "CountdownTxt");
            CountdownTxt.BorderStyle = BorderStyle.None;
            CountdownTxt.Name = "CountdownTxt";
            CountdownTxt.ReadOnly = true;
            // 
            // StartStopButton
            // 
            resources.ApplyResources(StartStopButton, "StartStopButton");
            StartStopButton.Name = "StartStopButton";
            StartStopButton.UseVisualStyleBackColor = true;
            StartStopButton.Click += StartStopButton_Click;
            // 
            // CycleLabel
            // 
            resources.ApplyResources(CycleLabel, "CycleLabel");
            CycleLabel.Name = "CycleLabel";
            // 
            // CycleNUD
            // 
            resources.ApplyResources(CycleNUD, "CycleNUD");
            CycleNUD.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            CycleNUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CycleNUD.Name = "CycleNUD";
            CycleNUD.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // UnitLabel
            // 
            resources.ApplyResources(UnitLabel, "UnitLabel");
            UnitLabel.Name = "UnitLabel";
            // 
            // Timer
            // 
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UnitLabel);
            Controls.Add(CycleNUD);
            Controls.Add(CycleLabel);
            Controls.Add(StartStopButton);
            Controls.Add(CountdownTxt);
            Name = "MainForm";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)CycleNUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CountdownTxt;
        private Button StartStopButton;
        private Label CycleLabel;
        private NumericUpDown CycleNUD;
        private Label UnitLabel;
        private System.Windows.Forms.Timer Timer;
    }
}
