using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Tibialyzer.Managers
{
    public class CombinatoricsManager
    {
        private Dictionary<string, int> monstersToKill;
        private Dictionary<string, int> oldMonstersToKill;

        public CombinatoricsManager()
        {
            monstersToKill = new Dictionary<string, int>();
            oldMonstersToKill = new Dictionary<string, int>();
        }

        public void CheckLogLine(string logLine)
        {
            
            string withoutTime = StripTime(logLine);

            //00:15 Combo! Next: 1. glooth anemone, 2. devourer, 3. glooth golem
            //00:30 Consecutive combo!Score x2!Next: 1.devourer, 2.glooth golem, 3.glooth anemone
            //00:38 Combo chain! Score x3! Next: 1. glooth anemone, 2. devourer, 3. glooth golem
            if (withoutTime.StartsWith("Combo!")
                || withoutTime.StartsWith("Consecutive combo!")
                || withoutTime.StartsWith("Combo chain!"))
            {
                Console.WriteLine("checking: " + logLine);
                if (!monstersToKill.ContainsKey(logLine)) {
                    monstersToKill[logLine] = 0;
                    ShowReport(logLine);
                }
                monstersToKill[logLine]++;
            }
        }

        public void ShowReport(string msg)
        {
            IEnumerable<Tibialyzer.Creature> monsters = 
                msg.Split(new string[] { "Next: " }, StringSplitOptions.None)[1].
                Split(new string[] { ", " }, StringSplitOptions.None).
                Select(item => StorageManager.getCreature(item.Substring(3)));

                MainForm.mainForm.Invoke((MethodInvoker)delegate {
                    PopupManager.ShowSimpleNotification(new CombinatoricsNotification(monsters));
                });
        }

        private string StripTime(string logLine)
        {
            return logLine.Substring(6);
        }

    }
}
