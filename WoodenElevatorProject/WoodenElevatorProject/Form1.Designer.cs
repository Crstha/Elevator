namespace WoodenElevatorProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblControlPanel = new System.Windows.Forms.Panel();
            this.TimerFirstFloorDoorOpen = new System.Windows.Forms.Timer(this.components);
            this.TimerFirstFloorDoorClose = new System.Windows.Forms.Timer(this.components);
            this.TimerGFloorDoorOpen = new System.Windows.Forms.Timer(this.components);
            this.TimerGFloorDoorClose = new System.Windows.Forms.Timer(this.components);
            this.TimerLiftDown = new System.Windows.Forms.Timer(this.components);
            this.TimerLiftUp = new System.Windows.Forms.Timer(this.components);
            this.pnlOuterDesign = new System.Windows.Forms.Panel();
            this.picGdisplay = new System.Windows.Forms.PictureBox();
            this.pic1display = new System.Windows.Forms.PictureBox();
            this.pnlUpr = new System.Windows.Forms.Panel();
            this.pnlLwr = new System.Windows.Forms.Panel();
            this.pnlBtm = new System.Windows.Forms.Panel();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.pnlShaft = new System.Windows.Forms.Panel();
            this.picLwrRightDoor = new System.Windows.Forms.PictureBox();
            this.picLwrLeftDoor = new System.Windows.Forms.PictureBox();
            this.picUprRightDoor = new System.Windows.Forms.PictureBox();
            this.picUprLeftDoor = new System.Windows.Forms.PictureBox();
            this.pnlLift = new System.Windows.Forms.Panel();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.pnlControlPanel = new System.Windows.Forms.Panel();
            this.picMainDisplay = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblControlPanel.SuspendLayout();
            this.pnlOuterDesign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGdisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1display)).BeginInit();
            this.pnlShaft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLwrRightDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLwrLeftDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUprRightDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUprLeftDoor)).BeginInit();
            this.pnlControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblControlPanel
            // 
            this.lblControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblControlPanel.Controls.Add(this.pnlOuterDesign);
            this.lblControlPanel.Controls.Add(this.btnDown);
            this.lblControlPanel.Controls.Add(this.btnUp);
            this.lblControlPanel.Controls.Add(this.pnlControlPanel);
            this.lblControlPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblControlPanel.Location = new System.Drawing.Point(1, 1);
            this.lblControlPanel.Name = "lblControlPanel";
            this.lblControlPanel.Size = new System.Drawing.Size(1077, 530);
            this.lblControlPanel.TabIndex = 0;
            // 
            // TimerFirstFloorDoorOpen
            // 
            this.TimerFirstFloorDoorOpen.Interval = 10;
            this.TimerFirstFloorDoorOpen.Tick += new System.EventHandler(this.TimerFirstFloorDoorOpen_Tick);
            // 
            // TimerFirstFloorDoorClose
            // 
            this.TimerFirstFloorDoorClose.Interval = 10;
            this.TimerFirstFloorDoorClose.Tick += new System.EventHandler(this.TimerFirstFloorDoorClose_Tick);
            // 
            // TimerGFloorDoorOpen
            // 
            this.TimerGFloorDoorOpen.Interval = 10;
            this.TimerGFloorDoorOpen.Tick += new System.EventHandler(this.TimerGFloorDoorOpen_Tick);
            // 
            // TimerGFloorDoorClose
            // 
            this.TimerGFloorDoorClose.Interval = 10;
            this.TimerGFloorDoorClose.Tick += new System.EventHandler(this.TimerGFloorDoorClose_Tick);
            // 
            // TimerLiftDown
            // 
            this.TimerLiftDown.Interval = 10;
            this.TimerLiftDown.Tick += new System.EventHandler(this.TimerLiftDown_Tick);
            // 
            // TimerLiftUp
            // 
            this.TimerLiftUp.Interval = 10;
            this.TimerLiftUp.Tick += new System.EventHandler(this.TimerLiftUp_Tick);
            // 
            // pnlOuterDesign
            // 
            this.pnlOuterDesign.BackgroundImage = global::WoodenElevatorProject.Properties.Resources.ddd;
            this.pnlOuterDesign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlOuterDesign.Controls.Add(this.picGdisplay);
            this.pnlOuterDesign.Controls.Add(this.pic1display);
            this.pnlOuterDesign.Controls.Add(this.pnlUpr);
            this.pnlOuterDesign.Controls.Add(this.pnlLwr);
            this.pnlOuterDesign.Controls.Add(this.pnlBtm);
            this.pnlOuterDesign.Controls.Add(this.pnlMiddle);
            this.pnlOuterDesign.Controls.Add(this.pnlShaft);
            this.pnlOuterDesign.Location = new System.Drawing.Point(45, 11);
            this.pnlOuterDesign.Name = "pnlOuterDesign";
            this.pnlOuterDesign.Size = new System.Drawing.Size(202, 509);
            this.pnlOuterDesign.TabIndex = 0;
            // 
            // picGdisplay
            // 
            this.picGdisplay.BackColor = System.Drawing.Color.Black;
            this.picGdisplay.Location = new System.Drawing.Point(83, 268);
            this.picGdisplay.Name = "picGdisplay";
            this.picGdisplay.Size = new System.Drawing.Size(47, 24);
            this.picGdisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGdisplay.TabIndex = 9;
            this.picGdisplay.TabStop = false;
            // 
            // pic1display
            // 
            this.pic1display.BackColor = System.Drawing.Color.Black;
            this.pic1display.Location = new System.Drawing.Point(80, 0);
            this.pic1display.Name = "pic1display";
            this.pic1display.Size = new System.Drawing.Size(47, 22);
            this.pic1display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1display.TabIndex = 8;
            this.pic1display.TabStop = false;
            // 
            // pnlUpr
            // 
            this.pnlUpr.BackgroundImage = global::WoodenElevatorProject.Properties.Resources.upper;
            this.pnlUpr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlUpr.Location = new System.Drawing.Point(23, 267);
            this.pnlUpr.Name = "pnlUpr";
            this.pnlUpr.Size = new System.Drawing.Size(162, 24);
            this.pnlUpr.TabIndex = 1;
            // 
            // pnlLwr
            // 
            this.pnlLwr.BackgroundImage = global::WoodenElevatorProject.Properties.Resources.upper;
            this.pnlLwr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLwr.Location = new System.Drawing.Point(23, 229);
            this.pnlLwr.Name = "pnlLwr";
            this.pnlLwr.Size = new System.Drawing.Size(162, 12);
            this.pnlLwr.TabIndex = 0;
            // 
            // pnlBtm
            // 
            this.pnlBtm.BackgroundImage = global::WoodenElevatorProject.Properties.Resources.upper;
            this.pnlBtm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBtm.Location = new System.Drawing.Point(23, 492);
            this.pnlBtm.Name = "pnlBtm";
            this.pnlBtm.Size = new System.Drawing.Size(162, 14);
            this.pnlBtm.TabIndex = 7;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.BackgroundImage = global::WoodenElevatorProject.Properties.Resources.WoodenTexture1;
            this.pnlMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 240);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(202, 28);
            this.pnlMiddle.TabIndex = 1;
            // 
            // pnlShaft
            // 
            this.pnlShaft.BackgroundImage = global::WoodenElevatorProject.Properties.Resources.WoodenTexture;
            this.pnlShaft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlShaft.Controls.Add(this.picLwrRightDoor);
            this.pnlShaft.Controls.Add(this.picLwrLeftDoor);
            this.pnlShaft.Controls.Add(this.picUprRightDoor);
            this.pnlShaft.Controls.Add(this.picUprLeftDoor);
            this.pnlShaft.Controls.Add(this.pnlLift);
            this.pnlShaft.Location = new System.Drawing.Point(24, 21);
            this.pnlShaft.Name = "pnlShaft";
            this.pnlShaft.Size = new System.Drawing.Size(161, 475);
            this.pnlShaft.TabIndex = 0;
            // 
            // picLwrRightDoor
            // 
            this.picLwrRightDoor.BackgroundImage = global::WoodenElevatorProject.Properties.Resources.RDoor;
            this.picLwrRightDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLwrRightDoor.Location = new System.Drawing.Point(83, 268);
            this.picLwrRightDoor.Name = "picLwrRightDoor";
            this.picLwrRightDoor.Size = new System.Drawing.Size(92, 207);
            this.picLwrRightDoor.TabIndex = 3;
            this.picLwrRightDoor.TabStop = false;
            // 
            // picLwrLeftDoor
            // 
            this.picLwrLeftDoor.BackgroundImage = global::WoodenElevatorProject.Properties.Resources.Ldoor;
            this.picLwrLeftDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLwrLeftDoor.Location = new System.Drawing.Point(-24, 265);
            this.picLwrLeftDoor.Name = "picLwrLeftDoor";
            this.picLwrLeftDoor.Size = new System.Drawing.Size(107, 207);
            this.picLwrLeftDoor.TabIndex = 2;
            this.picLwrLeftDoor.TabStop = false;
            // 
            // picUprRightDoor
            // 
            this.picUprRightDoor.BackgroundImage = global::WoodenElevatorProject.Properties.Resources.RDoor;
            this.picUprRightDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUprRightDoor.Location = new System.Drawing.Point(83, 0);
            this.picUprRightDoor.Name = "picUprRightDoor";
            this.picUprRightDoor.Size = new System.Drawing.Size(92, 213);
            this.picUprRightDoor.TabIndex = 1;
            this.picUprRightDoor.TabStop = false;
            // 
            // picUprLeftDoor
            // 
            this.picUprLeftDoor.BackgroundImage = global::WoodenElevatorProject.Properties.Resources.Ldoor;
            this.picUprLeftDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUprLeftDoor.Location = new System.Drawing.Point(-24, 0);
            this.picUprLeftDoor.Name = "picUprLeftDoor";
            this.picUprLeftDoor.Size = new System.Drawing.Size(107, 213);
            this.picUprLeftDoor.TabIndex = 0;
            this.picUprLeftDoor.TabStop = false;
            // 
            // pnlLift
            // 
            this.pnlLift.BackgroundImage = global::WoodenElevatorProject.Properties.Resources.Lift;
            this.pnlLift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLift.Location = new System.Drawing.Point(0, -2);
            this.pnlLift.Name = "pnlLift";
            this.pnlLift.Size = new System.Drawing.Size(161, 221);
            this.pnlLift.TabIndex = 2;
            // 
            // btnDown
            // 
            this.btnDown.BackgroundImage = global::WoodenElevatorProject.Properties.Resources.liftOpen;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDown.Location = new System.Drawing.Point(251, 356);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(43, 38);
            this.btnDown.TabIndex = 6;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackgroundImage = global::WoodenElevatorProject.Properties.Resources.liftOpen;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.Location = new System.Drawing.Point(250, 116);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(43, 38);
            this.btnUp.TabIndex = 2;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // pnlControlPanel
            // 
            this.pnlControlPanel.BackgroundImage = global::WoodenElevatorProject.Properties.Resources.WoodenTexture;
            this.pnlControlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlControlPanel.Controls.Add(this.picMainDisplay);
            this.pnlControlPanel.Controls.Add(this.label1);
            this.pnlControlPanel.Controls.Add(this.btnAlarm);
            this.pnlControlPanel.Controls.Add(this.btnG);
            this.pnlControlPanel.Controls.Add(this.btn1);
            this.pnlControlPanel.Controls.Add(this.btnClose);
            this.pnlControlPanel.Controls.Add(this.btnOpen);
            this.pnlControlPanel.Location = new System.Drawing.Point(311, 61);
            this.pnlControlPanel.Name = "pnlControlPanel";
            this.pnlControlPanel.Size = new System.Drawing.Size(183, 385);
            this.pnlControlPanel.TabIndex = 1;
            // 
            // picMainDisplay
            // 
            this.picMainDisplay.BackColor = System.Drawing.Color.Black;
            this.picMainDisplay.BackgroundImage = global::WoodenElevatorProject.Properties.Resources.black;
            this.picMainDisplay.ErrorImage = null;
            this.picMainDisplay.ImageLocation = "";
            this.picMainDisplay.InitialImage = null;
            this.picMainDisplay.Location = new System.Drawing.Point(9, 53);
            this.picMainDisplay.Name = "picMainDisplay";
            this.picMainDisplay.Size = new System.Drawing.Size(159, 82);
            this.picMainDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMainDisplay.TabIndex = 7;
            this.picMainDisplay.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Control Panel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAlarm
            // 
            this.btnAlarm.BackgroundImage = global::WoodenElevatorProject.Properties.Resources.btnalarm;
            this.btnAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlarm.Location = new System.Drawing.Point(64, 295);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(43, 38);
            this.btnAlarm.TabIndex = 5;
            this.btnAlarm.UseVisualStyleBackColor = true;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // btnG
            // 
            this.btnG.BackgroundImage = global::WoodenElevatorProject.Properties.Resources.btnG;
            this.btnG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnG.Location = new System.Drawing.Point(98, 233);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(43, 38);
            this.btnG.TabIndex = 4;
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btn1
            // 
            this.btn1.BackgroundImage = global::WoodenElevatorProject.Properties.Resources.btn1;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.Location = new System.Drawing.Point(32, 232);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(43, 38);
            this.btn1.TabIndex = 3;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::WoodenElevatorProject.Properties.Resources.liftClose;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(98, 168);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackgroundImage = global::WoodenElevatorProject.Properties.Resources.liftOpen;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpen.Location = new System.Drawing.Point(32, 168);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(43, 38);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 533);
            this.Controls.Add(this.lblControlPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.lblControlPanel.ResumeLayout(false);
            this.pnlOuterDesign.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGdisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1display)).EndInit();
            this.pnlShaft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLwrRightDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLwrLeftDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUprRightDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUprLeftDoor)).EndInit();
            this.pnlControlPanel.ResumeLayout(false);
            this.pnlControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lblControlPanel;
        private System.Windows.Forms.Panel pnlOuterDesign;
        private System.Windows.Forms.Panel pnlShaft;
        private System.Windows.Forms.Panel pnlLwr;
        private System.Windows.Forms.Panel pnlUpr;
        private System.Windows.Forms.Panel pnlLift;
        private System.Windows.Forms.PictureBox picUprRightDoor;
        private System.Windows.Forms.PictureBox picUprLeftDoor;
        private System.Windows.Forms.PictureBox picLwrRightDoor;
        private System.Windows.Forms.PictureBox picLwrLeftDoor;
        private System.Windows.Forms.Panel pnlControlPanel;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Panel pnlBtm;
        private System.Windows.Forms.Timer TimerFirstFloorDoorOpen;
        private System.Windows.Forms.Timer TimerFirstFloorDoorClose;
        private System.Windows.Forms.Timer TimerGFloorDoorOpen;
        private System.Windows.Forms.Timer TimerGFloorDoorClose;
        private System.Windows.Forms.Timer TimerLiftDown;
        private System.Windows.Forms.Timer TimerLiftUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picMainDisplay;
        private System.Windows.Forms.PictureBox picGdisplay;
        private System.Windows.Forms.PictureBox pic1display;
    }
}

