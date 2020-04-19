  1
  2
  3
  4
  5
  6
  7
  8
  9
 10
 11
 12
 13
 14
 15
 16
 17
 18
 19
 20
 21
 22
 23
 24
 25
 26
 27
 28
 29
 30
 31
 32
 33
 34
 35
 36
 37
 38
 39
 40
 41
 42
 43
 44
 45
 46
 47
 48
 49
 50
 51
 52
 53
 54
 55
 56
 57
 58
 59
 60
 61
 62
 63
 64
 65
 66
 67
 68
 69
 70
 71
 72
 73
 74
 75
 76
 77
 78
 79
 80
 81
 82
 83
 84
 85
 86
 87
 88
 89
 90
 91
 92
 93
 94
 95
 96
 97
 98
 99
100
101
102
103
104
105
106
107
108
109
110
111
112
113
114
115
116
117
118
119
120
121
122
123
124
125
126
127
128
129
130
131
132
133
134
135
136
137
138
139
140
141
142
143
144
145
146
147
148
149
150
151
152
153
154
155
156
157
158
159
160
161
162
163
164
165
166
167
168
169
170
171
172
173
174
175
176
177
178
179
180
181
182
183
184
185
186
187
188
189
190
191
192
193
namespace MathQuiz
{
    partial class frmMain
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
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblQ1 = new System.Windows.Forms.Label();
            this.numQ1 = new System.Windows.Forms.NumericUpDown();
            this.numQ2 = new System.Windows.Forms.NumericUpDown();
            this.lblQ2 = new System.Windows.Forms.Label();
            this.numQ3 = new System.Windows.Forms.NumericUpDown();
            this.lblQ3 = new System.Windows.Forms.Label();
            this.numQ4 = new System.Windows.Forms.NumericUpDown();
            this.lblQ4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timerQuiz = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numQ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimer.Location = new System.Drawing.Point(125, 14);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(255, 25);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "Pozostały czas: 20sek.";
            // 
            // lblQ1
            // 
            this.lblQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQ1.Location = new System.Drawing.Point(17, 80);
            this.lblQ1.Name = "lblQ1";
            this.lblQ1.Size = new System.Drawing.Size(207, 35);
            this.lblQ1.TabIndex = 1;
            this.lblQ1.Text = "12 + 12 =";
            this.lblQ1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numQ1
            // 
            this.numQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numQ1.Location = new System.Drawing.Point(241, 77);
            this.numQ1.Name = "numQ1";
            this.numQ1.Size = new System.Drawing.Size(120, 38);
            this.numQ1.TabIndex = 3;
            // 
            // numQ2
            // 
            this.numQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numQ2.Location = new System.Drawing.Point(241, 131);
            this.numQ2.Name = "numQ2";
            this.numQ2.Size = new System.Drawing.Size(120, 38);
            this.numQ2.TabIndex = 5;
            // 
            // lblQ2
            // 
            this.lblQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQ2.Location = new System.Drawing.Point(17, 134);
            this.lblQ2.Name = "lblQ2";
            this.lblQ2.Size = new System.Drawing.Size(207, 35);
            this.lblQ2.TabIndex = 4;
            this.lblQ2.Text = "12 + 12 =";
            this.lblQ2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numQ3
            // 
            this.numQ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numQ3.Location = new System.Drawing.Point(241, 184);
            this.numQ3.Name = "numQ3";
            this.numQ3.Size = new System.Drawing.Size(120, 38);
            this.numQ3.TabIndex = 7;
            // 
            // lblQ3
            // 
            this.lblQ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQ3.Location = new System.Drawing.Point(17, 187);
            this.lblQ3.Name = "lblQ3";
            this.lblQ3.Size = new System.Drawing.Size(207, 35);
            this.lblQ3.TabIndex = 6;
            this.lblQ3.Text = "12 + 12 =";
            this.lblQ3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numQ4
            // 
            this.numQ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numQ4.Location = new System.Drawing.Point(241, 237);
            this.numQ4.Name = "numQ4";
            this.numQ4.Size = new System.Drawing.Size(120, 38);
            this.numQ4.TabIndex = 9;
            // 
            // lblQ4
            // 
            this.lblQ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQ4.Location = new System.Drawing.Point(17, 240);
            this.lblQ4.Name = "lblQ4";
            this.lblQ4.Size = new System.Drawing.Size(207, 35);
            this.lblQ4.TabIndex = 8;
            this.lblQ4.Text = "12 + 12 =";
            this.lblQ4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(156, 305);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(190, 48);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timerQuiz
            // 
            this.timerQuiz.Interval = 1000;
            this.timerQuiz.Tick += new System.EventHandler(this.timerQuiz_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numQ4);
            this.Controls.Add(this.lblQ4);
            this.Controls.Add(this.numQ3);
            this.Controls.Add(this.lblQ3);
            this.Controls.Add(this.numQ2);
            this.Controls.Add(this.lblQ2);
            this.Controls.Add(this.numQ1);
            this.Controls.Add(this.lblQ1);
            this.Controls.Add(this.lblTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Quiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblQ1;
        private System.Windows.Forms.NumericUpDown numQ1;
        private System.Windows.Forms.NumericUpDown numQ2;
        private System.Windows.Forms.Label lblQ2;
        private System.Windows.Forms.NumericUpDown numQ3;
        private System.Windows.Forms.Label lblQ3;
        private System.Windows.Forms.NumericUpDown numQ4;
        private System.Windows.Forms.Label lblQ4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timerQuiz;
    }
}