
// Copyright 2016 Mark Raasveldt
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Tibialyzer {
    class CombinatoricsNotification : SimpleNotification {
        private Label firstWindowName;
        private PictureBox firstCreatureBox;
        private PictureBox secondCreatureBox;
        private PictureBox thirdCreatureBox;

        public CombinatoricsNotification(IEnumerable<Tibialyzer.Creature> creatures) : base() {
            this.InitializeComponent();

            //this.Size = new Size(SettingsManager.getSettingInt("SimpleNotificationWidth"), this.Size.Height);


            this.InitializeSimpleNotification(extraTime: 30.0);

            firstCreatureBox.Click -= c_Click;
            secondCreatureBox.Click -= c_Click;
            thirdCreatureBox.Click -= c_Click;

            this.firstCreatureBox.Image = creatures.ElementAt(0).image;
            this.secondCreatureBox.Image = creatures.ElementAt(1).image;
            this.thirdCreatureBox.Image = creatures.ElementAt(2).image;
        }

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CombinatoricsNotification));
            this.firstWindowName = new System.Windows.Forms.Label();
            this.firstCreatureBox = new System.Windows.Forms.PictureBox();
            this.thirdCreatureBox = new System.Windows.Forms.PictureBox();
            this.secondCreatureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.firstCreatureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdCreatureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCreatureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // firstWindowName
            // 
            this.firstWindowName.AutoSize = true;
            this.firstWindowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstWindowName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.firstWindowName.Location = new System.Drawing.Point(12, 9);
            this.firstWindowName.Name = "firstWindowName";
            this.firstWindowName.Size = new System.Drawing.Size(133, 13);
            this.firstWindowName.TabIndex = 0;
            this.firstWindowName.Text = "Combinatorics targets:";
            // 
            // firstCreatureBox
            // 
            this.firstCreatureBox.Location = new System.Drawing.Point(12, 25);
            this.firstCreatureBox.Name = "firstCreatureBox";
            this.firstCreatureBox.Size = new System.Drawing.Size(60, 60);
            this.firstCreatureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.firstCreatureBox.TabIndex = 1;
            this.firstCreatureBox.TabStop = false;
            // 
            // thirdCreatureBox
            // 
            this.thirdCreatureBox.Location = new System.Drawing.Point(144, 25);
            this.thirdCreatureBox.Name = "thirdCreatureBox";
            this.thirdCreatureBox.Size = new System.Drawing.Size(60, 60);
            this.thirdCreatureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thirdCreatureBox.TabIndex = 2;
            this.thirdCreatureBox.TabStop = false;
            // 
            // secondCreatureBox
            // 
            this.secondCreatureBox.Location = new System.Drawing.Point(78, 25);
            this.secondCreatureBox.Name = "secondCreatureBox";
            this.secondCreatureBox.Size = new System.Drawing.Size(60, 60);
            this.secondCreatureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.secondCreatureBox.TabIndex = 3;
            this.secondCreatureBox.TabStop = false;
            // 
            // CombinatoricsNotification
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(216, 95);
            this.Controls.Add(this.secondCreatureBox);
            this.Controls.Add(this.thirdCreatureBox);
            this.Controls.Add(this.firstCreatureBox);
            this.Controls.Add(this.firstWindowName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CombinatoricsNotification";
            this.Text = "Loot Notification";
            ((System.ComponentModel.ISupportInitialize)(this.firstCreatureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdCreatureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCreatureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
