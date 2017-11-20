namespace TelerikWinFormsApp_Calendar2
{
    partial class RadForm1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.ThemeSource themeSource1 = new Telerik.WinControls.ThemeSource();
            Telerik.WinControls.ThemeSource themeSource2 = new Telerik.WinControls.ThemeSource();
            this.radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radCalendar1
            // 
            this.radCalendar1.AllowColumnHeaderSelectors = true;
            this.radCalendar1.AllowMultipleSelect = true;
            this.radCalendar1.AllowMultipleView = true;
            this.radCalendar1.AllowRowHeaderSelectors = true;
            this.radCalendar1.Location = new System.Drawing.Point(12, 4);
            this.radCalendar1.MultiViewColumns = 4;
            this.radCalendar1.MultiViewRows = 2;
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.ShowFooter = true;
            this.radCalendar1.ShowOtherMonthsDays = false;
            this.radCalendar1.ShowRowHeaders = true;
            this.radCalendar1.ShowViewSelector = true;
            this.radCalendar1.Size = new System.Drawing.Size(943, 343);
            this.radCalendar1.TabIndex = 0;
            this.radCalendar1.Text = "radCalendar1";
            this.radCalendar1.ThemeName = "MyCalendar10";
            // 
            // radThemeManager1
            // 
            themeSource1.ThemeLocation = "D:\\VisualBuilder\\MyCalendar10_Repository.xml";
            themeSource2.ThemeLocation = "D:\\VisualBuilder\\MyCalendar10_Telerik_WinControls_UI_RadCalendar.xml";
            this.radThemeManager1.LoadedThemes.AddRange(new Telerik.WinControls.ThemeSource[] {
            themeSource1,
            themeSource2});
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 359);
            this.Controls.Add(this.radCalendar1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
    }
}