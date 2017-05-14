namespace WindowsFormsApp6
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.textUitvoer = new System.Windows.Forms.TextBox();
            this.btnWortel = new System.Windows.Forms.Button();
            this.btnPlusMin = new System.Windows.Forms.Button();
            this.btnIsAntwoord = new System.Windows.Forms.Button();
            this.btnNul = new System.Windows.Forms.Button();
            this.btnKomma = new System.Windows.Forms.Button();
            this.btnDrie = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnTwee = new System.Windows.Forms.Button();
            this.btnEen = new System.Windows.Forms.Button();
            this.btnZes = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnVijf = new System.Windows.Forms.Button();
            this.btnVier = new System.Windows.Forms.Button();
            this.btnNegen = new System.Windows.Forms.Button();
            this.btnKeer = new System.Windows.Forms.Button();
            this.btnAcht = new System.Windows.Forms.Button();
            this.btnZeven = new System.Windows.Forms.Button();
            this.btnDerdeMacht = new System.Windows.Forms.Button();
            this.btnGedeeldDoor = new System.Windows.Forms.Button();
            this.btnKwadraat = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMemoryMinus = new System.Windows.Forms.Button();
            this.btnMemoryPlus = new System.Windows.Forms.Button();
            this.btnMemoryStore = new System.Windows.Forms.Button();
            this.btnMemoryClear = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnEuroTeken = new System.Windows.Forms.Button();
            this.btnMemoryRecall = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textUitvoerPrime = new System.Windows.Forms.TextBox();
            this.textUitvoerMemory = new System.Windows.Forms.TextBox();
            this.textUitvoerFibonacci = new System.Windows.Forms.TextBox();
            this.btnFibonacci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textUitvoer
            // 
            this.textUitvoer.BackColor = System.Drawing.SystemColors.Control;
            this.textUitvoer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUitvoer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUitvoer.Enabled = false;
            this.textUitvoer.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUitvoer.Location = new System.Drawing.Point(46, 35);
            this.textUitvoer.Multiline = true;
            this.textUitvoer.Name = "textUitvoer";
            this.textUitvoer.ReadOnly = true;
            this.textUitvoer.Size = new System.Drawing.Size(378, 49);
            this.textUitvoer.TabIndex = 58;
            this.textUitvoer.Text = "0";
            this.textUitvoer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textUitvoer.TextChanged += new System.EventHandler(this.textUitvoer_TextChanged);
            // 
            // btnWortel
            // 
            this.btnWortel.BackColor = System.Drawing.Color.Silver;
            this.btnWortel.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnWortel.Location = new System.Drawing.Point(334, 99);
            this.btnWortel.Name = "btnWortel";
            this.btnWortel.Size = new System.Drawing.Size(90, 45);
            this.btnWortel.TabIndex = 57;
            this.btnWortel.Text = "√";
            this.btnWortel.UseVisualStyleBackColor = false;
            this.btnWortel.Click += new System.EventHandler(this.btn_commandoWortel);
            // 
            // btnPlusMin
            // 
            this.btnPlusMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPlusMin.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusMin.Location = new System.Drawing.Point(238, 316);
            this.btnPlusMin.Name = "btnPlusMin";
            this.btnPlusMin.Size = new System.Drawing.Size(90, 45);
            this.btnPlusMin.TabIndex = 56;
            this.btnPlusMin.Text = "+ / -";
            this.btnPlusMin.UseVisualStyleBackColor = false;
            this.btnPlusMin.Click += new System.EventHandler(this.btnPlusMin_Click);
            // 
            // btnIsAntwoord
            // 
            this.btnIsAntwoord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIsAntwoord.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.btnIsAntwoord.ForeColor = System.Drawing.Color.White;
            this.btnIsAntwoord.Location = new System.Drawing.Point(334, 367);
            this.btnIsAntwoord.Name = "btnIsAntwoord";
            this.btnIsAntwoord.Size = new System.Drawing.Size(186, 45);
            this.btnIsAntwoord.TabIndex = 55;
            this.btnIsAntwoord.Text = "=";
            this.btnIsAntwoord.UseVisualStyleBackColor = false;
            this.btnIsAntwoord.Click += new System.EventHandler(this.btnIsAntwoord_Click);
            // 
            // btnNul
            // 
            this.btnNul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNul.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNul.Location = new System.Drawing.Point(142, 316);
            this.btnNul.Name = "btnNul";
            this.btnNul.Size = new System.Drawing.Size(90, 45);
            this.btnNul.TabIndex = 54;
            this.btnNul.Text = "0";
            this.btnNul.UseVisualStyleBackColor = false;
            this.btnNul.Click += new System.EventHandler(this.btn_click);
            // 
            // btnKomma
            // 
            this.btnKomma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnKomma.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKomma.Location = new System.Drawing.Point(46, 316);
            this.btnKomma.Name = "btnKomma";
            this.btnKomma.Size = new System.Drawing.Size(90, 45);
            this.btnKomma.TabIndex = 53;
            this.btnKomma.Text = ",";
            this.btnKomma.UseVisualStyleBackColor = false;
            this.btnKomma.Click += new System.EventHandler(this.btn_click_komma);
            // 
            // btnDrie
            // 
            this.btnDrie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDrie.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrie.Location = new System.Drawing.Point(238, 265);
            this.btnDrie.Name = "btnDrie";
            this.btnDrie.Size = new System.Drawing.Size(90, 45);
            this.btnDrie.TabIndex = 52;
            this.btnDrie.Text = "3";
            this.btnDrie.UseVisualStyleBackColor = false;
            this.btnDrie.Click += new System.EventHandler(this.btn_click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Silver;
            this.btnPlus.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(334, 316);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(90, 45);
            this.btnPlus.TabIndex = 51;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btn_commando);
            // 
            // btnTwee
            // 
            this.btnTwee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTwee.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwee.Location = new System.Drawing.Point(142, 265);
            this.btnTwee.Name = "btnTwee";
            this.btnTwee.Size = new System.Drawing.Size(90, 45);
            this.btnTwee.TabIndex = 50;
            this.btnTwee.Text = "2";
            this.btnTwee.UseVisualStyleBackColor = false;
            this.btnTwee.Click += new System.EventHandler(this.btn_click);
            // 
            // btnEen
            // 
            this.btnEen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEen.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEen.Location = new System.Drawing.Point(46, 265);
            this.btnEen.Name = "btnEen";
            this.btnEen.Size = new System.Drawing.Size(90, 45);
            this.btnEen.TabIndex = 49;
            this.btnEen.Text = "1";
            this.btnEen.UseVisualStyleBackColor = false;
            this.btnEen.Click += new System.EventHandler(this.btn_click);
            // 
            // btnZes
            // 
            this.btnZes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnZes.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZes.Location = new System.Drawing.Point(238, 214);
            this.btnZes.Name = "btnZes";
            this.btnZes.Size = new System.Drawing.Size(90, 45);
            this.btnZes.TabIndex = 48;
            this.btnZes.Text = "6";
            this.btnZes.UseVisualStyleBackColor = false;
            this.btnZes.Click += new System.EventHandler(this.btn_click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Silver;
            this.btnMin.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnMin.Location = new System.Drawing.Point(334, 265);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(90, 45);
            this.btnMin.TabIndex = 47;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btn_commando);
            // 
            // btnVijf
            // 
            this.btnVijf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVijf.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVijf.Location = new System.Drawing.Point(142, 214);
            this.btnVijf.Name = "btnVijf";
            this.btnVijf.Size = new System.Drawing.Size(90, 45);
            this.btnVijf.TabIndex = 46;
            this.btnVijf.Text = "5";
            this.btnVijf.UseVisualStyleBackColor = false;
            this.btnVijf.Click += new System.EventHandler(this.btn_click);
            // 
            // btnVier
            // 
            this.btnVier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVier.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVier.Location = new System.Drawing.Point(46, 214);
            this.btnVier.Name = "btnVier";
            this.btnVier.Size = new System.Drawing.Size(90, 45);
            this.btnVier.TabIndex = 45;
            this.btnVier.Text = "4";
            this.btnVier.UseVisualStyleBackColor = false;
            this.btnVier.Click += new System.EventHandler(this.btn_click);
            // 
            // btnNegen
            // 
            this.btnNegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNegen.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegen.Location = new System.Drawing.Point(238, 163);
            this.btnNegen.Name = "btnNegen";
            this.btnNegen.Size = new System.Drawing.Size(90, 45);
            this.btnNegen.TabIndex = 44;
            this.btnNegen.Text = "9";
            this.btnNegen.UseVisualStyleBackColor = false;
            this.btnNegen.Click += new System.EventHandler(this.btn_click);
            // 
            // btnKeer
            // 
            this.btnKeer.BackColor = System.Drawing.Color.Silver;
            this.btnKeer.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeer.Location = new System.Drawing.Point(334, 214);
            this.btnKeer.Name = "btnKeer";
            this.btnKeer.Size = new System.Drawing.Size(90, 45);
            this.btnKeer.TabIndex = 43;
            this.btnKeer.Text = "x";
            this.btnKeer.UseVisualStyleBackColor = false;
            this.btnKeer.Click += new System.EventHandler(this.btn_commando);
            // 
            // btnAcht
            // 
            this.btnAcht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAcht.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcht.Location = new System.Drawing.Point(142, 163);
            this.btnAcht.Name = "btnAcht";
            this.btnAcht.Size = new System.Drawing.Size(90, 45);
            this.btnAcht.TabIndex = 42;
            this.btnAcht.Text = "8";
            this.btnAcht.UseVisualStyleBackColor = false;
            this.btnAcht.Click += new System.EventHandler(this.btn_click);
            // 
            // btnZeven
            // 
            this.btnZeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnZeven.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZeven.Location = new System.Drawing.Point(46, 163);
            this.btnZeven.Name = "btnZeven";
            this.btnZeven.Size = new System.Drawing.Size(90, 45);
            this.btnZeven.TabIndex = 41;
            this.btnZeven.Text = "7";
            this.btnZeven.UseVisualStyleBackColor = false;
            this.btnZeven.Click += new System.EventHandler(this.btn_click);
            // 
            // btnDerdeMacht
            // 
            this.btnDerdeMacht.BackColor = System.Drawing.Color.Silver;
            this.btnDerdeMacht.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnDerdeMacht.Location = new System.Drawing.Point(238, 99);
            this.btnDerdeMacht.Name = "btnDerdeMacht";
            this.btnDerdeMacht.Size = new System.Drawing.Size(90, 45);
            this.btnDerdeMacht.TabIndex = 40;
            this.btnDerdeMacht.Text = "x³";
            this.btnDerdeMacht.UseVisualStyleBackColor = false;
            this.btnDerdeMacht.Click += new System.EventHandler(this.btn_commandoDerdeMacht);
            // 
            // btnGedeeldDoor
            // 
            this.btnGedeeldDoor.BackColor = System.Drawing.Color.Silver;
            this.btnGedeeldDoor.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnGedeeldDoor.Location = new System.Drawing.Point(334, 163);
            this.btnGedeeldDoor.Name = "btnGedeeldDoor";
            this.btnGedeeldDoor.Size = new System.Drawing.Size(90, 45);
            this.btnGedeeldDoor.TabIndex = 39;
            this.btnGedeeldDoor.Text = "÷";
            this.btnGedeeldDoor.UseVisualStyleBackColor = false;
            this.btnGedeeldDoor.Click += new System.EventHandler(this.btn_commando);
            // 
            // btnKwadraat
            // 
            this.btnKwadraat.BackColor = System.Drawing.Color.Silver;
            this.btnKwadraat.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnKwadraat.Location = new System.Drawing.Point(142, 99);
            this.btnKwadraat.Name = "btnKwadraat";
            this.btnKwadraat.Size = new System.Drawing.Size(90, 45);
            this.btnKwadraat.TabIndex = 38;
            this.btnKwadraat.Text = "x²";
            this.btnKwadraat.UseVisualStyleBackColor = false;
            this.btnKwadraat.Click += new System.EventHandler(this.btn_commandoKwadraat);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnClear.Location = new System.Drawing.Point(46, 99);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 45);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.clear_click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Calibri", 11F);
            this.button1.Location = new System.Drawing.Point(46, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 45);
            this.button1.TabIndex = 64;
            this.button1.Text = "π";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_commando_pi);
            // 
            // btnMemoryMinus
            // 
            this.btnMemoryMinus.BackColor = System.Drawing.Color.DimGray;
            this.btnMemoryMinus.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMemoryMinus.Location = new System.Drawing.Point(430, 265);
            this.btnMemoryMinus.Name = "btnMemoryMinus";
            this.btnMemoryMinus.Size = new System.Drawing.Size(90, 45);
            this.btnMemoryMinus.TabIndex = 62;
            this.btnMemoryMinus.Text = "M -";
            this.btnMemoryMinus.UseVisualStyleBackColor = false;
            this.btnMemoryMinus.Click += new System.EventHandler(this.btn_commando_memory);
            // 
            // btnMemoryPlus
            // 
            this.btnMemoryPlus.BackColor = System.Drawing.Color.DimGray;
            this.btnMemoryPlus.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMemoryPlus.Location = new System.Drawing.Point(430, 315);
            this.btnMemoryPlus.Name = "btnMemoryPlus";
            this.btnMemoryPlus.Size = new System.Drawing.Size(90, 45);
            this.btnMemoryPlus.TabIndex = 61;
            this.btnMemoryPlus.Text = "M +";
            this.btnMemoryPlus.UseVisualStyleBackColor = false;
            this.btnMemoryPlus.Click += new System.EventHandler(this.btn_commando_memory);
            // 
            // btnMemoryStore
            // 
            this.btnMemoryStore.BackColor = System.Drawing.Color.DimGray;
            this.btnMemoryStore.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMemoryStore.Location = new System.Drawing.Point(430, 163);
            this.btnMemoryStore.Name = "btnMemoryStore";
            this.btnMemoryStore.Size = new System.Drawing.Size(90, 45);
            this.btnMemoryStore.TabIndex = 60;
            this.btnMemoryStore.Text = "M Store";
            this.btnMemoryStore.UseVisualStyleBackColor = false;
            this.btnMemoryStore.Click += new System.EventHandler(this.btn_commando_memory);
            // 
            // btnMemoryClear
            // 
            this.btnMemoryClear.BackColor = System.Drawing.Color.DimGray;
            this.btnMemoryClear.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMemoryClear.Location = new System.Drawing.Point(430, 99);
            this.btnMemoryClear.Name = "btnMemoryClear";
            this.btnMemoryClear.Size = new System.Drawing.Size(90, 45);
            this.btnMemoryClear.TabIndex = 65;
            this.btnMemoryClear.Text = "M Clear";
            this.btnMemoryClear.UseVisualStyleBackColor = false;
            this.btnMemoryClear.Click += new System.EventHandler(this.btn_commando_memory);
            // 
            // btnFactorial
            // 
            this.btnFactorial.BackColor = System.Drawing.Color.Silver;
            this.btnFactorial.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnFactorial.Location = new System.Drawing.Point(142, 367);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(90, 45);
            this.btnFactorial.TabIndex = 66;
            this.btnFactorial.Text = "1 / x";
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.btn_commando_een_gedeeld_door_x);
            // 
            // btnEuroTeken
            // 
            this.btnEuroTeken.BackColor = System.Drawing.Color.Silver;
            this.btnEuroTeken.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnEuroTeken.Location = new System.Drawing.Point(238, 367);
            this.btnEuroTeken.Name = "btnEuroTeken";
            this.btnEuroTeken.Size = new System.Drawing.Size(90, 45);
            this.btnEuroTeken.TabIndex = 67;
            this.btnEuroTeken.Text = "€";
            this.btnEuroTeken.UseVisualStyleBackColor = false;
            // 
            // btnMemoryRecall
            // 
            this.btnMemoryRecall.BackColor = System.Drawing.Color.DimGray;
            this.btnMemoryRecall.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryRecall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMemoryRecall.Location = new System.Drawing.Point(430, 213);
            this.btnMemoryRecall.Name = "btnMemoryRecall";
            this.btnMemoryRecall.Size = new System.Drawing.Size(90, 45);
            this.btnMemoryRecall.TabIndex = 68;
            this.btnMemoryRecall.Text = "M Recall";
            this.btnMemoryRecall.UseVisualStyleBackColor = false;
            this.btnMemoryRecall.Click += new System.EventHandler(this.btn_commando_memory);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(526, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 41);
            this.button2.TabIndex = 69;
            this.button2.Text = "Test for Prime Number";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_commando_test_for_prime);
            // 
            // textUitvoerPrime
            // 
            this.textUitvoerPrime.BackColor = System.Drawing.SystemColors.Control;
            this.textUitvoerPrime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUitvoerPrime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUitvoerPrime.Enabled = false;
            this.textUitvoerPrime.Font = new System.Drawing.Font("Calibri", 8F);
            this.textUitvoerPrime.Location = new System.Drawing.Point(526, 265);
            this.textUitvoerPrime.Multiline = true;
            this.textUitvoerPrime.Name = "textUitvoerPrime";
            this.textUitvoerPrime.ReadOnly = true;
            this.textUitvoerPrime.Size = new System.Drawing.Size(248, 45);
            this.textUitvoerPrime.TabIndex = 70;
            this.textUitvoerPrime.TextChanged += new System.EventHandler(this.textUitvoerPrime_TextChanged);
            // 
            // textUitvoerMemory
            // 
            this.textUitvoerMemory.BackColor = System.Drawing.SystemColors.Control;
            this.textUitvoerMemory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUitvoerMemory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUitvoerMemory.Enabled = false;
            this.textUitvoerMemory.Font = new System.Drawing.Font("Calibri", 8F);
            this.textUitvoerMemory.Location = new System.Drawing.Point(526, 163);
            this.textUitvoerMemory.Multiline = true;
            this.textUitvoerMemory.Name = "textUitvoerMemory";
            this.textUitvoerMemory.ReadOnly = true;
            this.textUitvoerMemory.Size = new System.Drawing.Size(248, 44);
            this.textUitvoerMemory.TabIndex = 71;
            this.textUitvoerMemory.TextChanged += new System.EventHandler(this.textUitvoerMemory_TextChanged);
            // 
            // textUitvoerFibonacci
            // 
            this.textUitvoerFibonacci.BackColor = System.Drawing.SystemColors.Control;
            this.textUitvoerFibonacci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUitvoerFibonacci.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUitvoerFibonacci.Enabled = false;
            this.textUitvoerFibonacci.Font = new System.Drawing.Font("Calibri", 8F);
            this.textUitvoerFibonacci.Location = new System.Drawing.Point(526, 367);
            this.textUitvoerFibonacci.Multiline = true;
            this.textUitvoerFibonacci.Name = "textUitvoerFibonacci";
            this.textUitvoerFibonacci.ReadOnly = true;
            this.textUitvoerFibonacci.Size = new System.Drawing.Size(248, 45);
            this.textUitvoerFibonacci.TabIndex = 72;
            this.textUitvoerFibonacci.TextChanged += new System.EventHandler(this.textUitvoerFibonacci_TextChanged);
            // 
            // btnFibonacci
            // 
            this.btnFibonacci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFibonacci.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnFibonacci.ForeColor = System.Drawing.Color.White;
            this.btnFibonacci.Location = new System.Drawing.Point(526, 315);
            this.btnFibonacci.Name = "btnFibonacci";
            this.btnFibonacci.Size = new System.Drawing.Size(218, 41);
            this.btnFibonacci.TabIndex = 73;
            this.btnFibonacci.Text = "Test for Fibonacci Number";
            this.btnFibonacci.UseVisualStyleBackColor = false;
            this.btnFibonacci.Click += new System.EventHandler(this.btn_commando_test_for_fibonacci);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 446);
            this.Controls.Add(this.btnFibonacci);
            this.Controls.Add(this.textUitvoerFibonacci);
            this.Controls.Add(this.textUitvoerMemory);
            this.Controls.Add(this.textUitvoerPrime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMemoryRecall);
            this.Controls.Add(this.btnEuroTeken);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnMemoryClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMemoryMinus);
            this.Controls.Add(this.btnMemoryPlus);
            this.Controls.Add(this.btnMemoryStore);
            this.Controls.Add(this.textUitvoer);
            this.Controls.Add(this.btnWortel);
            this.Controls.Add(this.btnPlusMin);
            this.Controls.Add(this.btnIsAntwoord);
            this.Controls.Add(this.btnNul);
            this.Controls.Add(this.btnKomma);
            this.Controls.Add(this.btnDrie);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnTwee);
            this.Controls.Add(this.btnEen);
            this.Controls.Add(this.btnZes);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnVijf);
            this.Controls.Add(this.btnVier);
            this.Controls.Add(this.btnNegen);
            this.Controls.Add(this.btnKeer);
            this.Controls.Add(this.btnAcht);
            this.Controls.Add(this.btnZeven);
            this.Controls.Add(this.btnDerdeMacht);
            this.Controls.Add(this.btnGedeeldDoor);
            this.Controls.Add(this.btnKwadraat);
            this.Controls.Add(this.btnClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textUitvoer;
        private System.Windows.Forms.Button btnWortel;
        private System.Windows.Forms.Button btnPlusMin;
        private System.Windows.Forms.Button btnIsAntwoord;
        private System.Windows.Forms.Button btnNul;
        private System.Windows.Forms.Button btnKomma;
        private System.Windows.Forms.Button btnDrie;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnTwee;
        private System.Windows.Forms.Button btnEen;
        private System.Windows.Forms.Button btnZes;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnVijf;
        private System.Windows.Forms.Button btnVier;
        private System.Windows.Forms.Button btnNegen;
        private System.Windows.Forms.Button btnKeer;
        private System.Windows.Forms.Button btnAcht;
        private System.Windows.Forms.Button btnZeven;
        private System.Windows.Forms.Button btnDerdeMacht;
        private System.Windows.Forms.Button btnGedeeldDoor;
        private System.Windows.Forms.Button btnKwadraat;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMemoryMinus;
        private System.Windows.Forms.Button btnMemoryPlus;
        private System.Windows.Forms.Button btnMemoryStore;
        private System.Windows.Forms.Button btnMemoryClear;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnEuroTeken;
        private System.Windows.Forms.Button btnMemoryRecall;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textUitvoerPrime;
        private System.Windows.Forms.TextBox textUitvoerMemory;
        private System.Windows.Forms.TextBox textUitvoerFibonacci;
        private System.Windows.Forms.Button btnFibonacci;
    }
}

