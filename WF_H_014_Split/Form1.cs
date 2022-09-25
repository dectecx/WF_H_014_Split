using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_H_014_Split
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 文字OnChange
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            // 取得輸入字串
            string input = txtInput.Text;
            // 統一所有分割符號,將全部先改成逗點
            input = input.Replace(" ", ",").Replace(".", ",");
            // 切割字串
            string[] inputSplit = input.Split(',');
            // ==========統計數量Start==========
            // 建立一個字典(Dict)
            Dictionary<string, int> dict = new Dictionary<string, int>();
            // 迴圈遍歷所有切割後字串
            foreach (string str in inputSplit)
            {
                // 略過空字串
                if (string.IsNullOrWhiteSpace(str))
                {
                    continue;
                }

                // 先檢查字典裡面是否已經記錄過這個字串
                if (dict.ContainsKey(str))
                {
                    // 若有紀錄過,直接增加一個計數
                    dict[str]++;
                }
                else
                {
                    // 若無,則加入字典,並記錄出現一次
                    dict.Add(str, 1);
                }
            }
            // ==========統計數量End==========
            // 排序,讓輸出比較好看
            var dictSort = dict.OrderBy(x => x.Key);
            // 輸出結果
            string outputStr = "";
            foreach(KeyValuePair<string, int> item in dictSort)
            {
                outputStr += item.Key + ":" + item.Value + "\n";
            }
            lblOutput.Text = outputStr;
        }
    }
}
