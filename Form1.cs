using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace AndroidDataViewer
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=AndroidData;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        // Load Contacts from device
        private void BtnLoadContacts_Click(object sender, EventArgs e)
        {
            string output = ExecuteAdbCommand("shell content query --uri content://contacts/phones/");
            dgvContacts.DataSource = ParseAdbOutput(output, new[] { "display_name", "number" });
        }

        // Save Contacts to database
        private void BtnSaveContactsToDB_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach (DataGridViewRow row in dgvContacts.Rows)
                {
                    if (row.IsNewRow) continue;
                    string name = row.Cells["display_name"].Value?.ToString();
                    string number = row.Cells["number"].Value?.ToString();
                    if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(number)) continue;  // Add a null/empty check
                    string query = "INSERT INTO ContactsTable (Name, PhoneNumber) VALUES (@name, @number)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@number", number);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Contacts saved to DB.");
            }
        }

        // Load SMS
        private void BtnLoadSMS_Click(object sender, EventArgs e)
        {
            string output = ExecuteAdbCommand("shell content query --uri content://sms/");
            dgvSMS.DataSource = ParseAdbOutput(output, new[] { "address", "body", "date" });
        }

        // Save SMS
        private void BtnSaveSMSToDB_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach (DataGridViewRow row in dgvSMS.Rows)
                {
                    if (row.IsNewRow) continue;
                    string senderAddress = row.Cells["address"].Value?.ToString();
                    string message = row.Cells["body"].Value?.ToString();
                    string timestamp = row.Cells["date"].Value?.ToString();
                    if (string.IsNullOrEmpty(senderAddress) || string.IsNullOrEmpty(message) || string.IsNullOrEmpty(timestamp)) continue;  // Add null/empty check
                    string query = "INSERT INTO MessagesTable (Sender, MessageContent, Timestamp) VALUES (@sender, @msg, @ts)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@sender", senderAddress);
                        cmd.Parameters.AddWithValue("@msg", message);
                        cmd.Parameters.AddWithValue("@ts", timestamp);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("SMS saved to DB.");
            }
        }

        // Load Call Logs
        private void BtnLoadCalls_Click(object sender, EventArgs e)
        {
            string output = ExecuteAdbCommand("shell content query --uri content://call_log/calls/");
            dgvCalls.DataSource = ParseAdbOutput(output, new[] { "number", "type", "duration" });
        }

        // Save Call Logs
        private void BtnSaveCallsToDB_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach (DataGridViewRow row in dgvCalls.Rows)
                {
                    if (row.IsNewRow) continue;
                    string number = row.Cells["number"].Value?.ToString();
                    string type = row.Cells["type"].Value?.ToString();
                    string duration = row.Cells["duration"].Value?.ToString();
                    if (string.IsNullOrEmpty(number) || string.IsNullOrEmpty(type) || string.IsNullOrEmpty(duration)) continue;  // Add null/empty check
                    string query = "INSERT INTO CallLogsTable (PhoneNumber, CallType, Duration) VALUES (@num, @type, @dur)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@num", number);
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@dur", duration);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Call logs saved to DB.");
            }
        }

        // Load Device Info
        private void BtnLoadDeviceInfo_Click(object sender, EventArgs e)
        {
            string cpuInfo = ExecuteAdbCommand("shell cat /proc/cpuinfo");
            string memInfo = ExecuteAdbCommand("shell cat /proc/meminfo");
            txtDeviceInfo.Text = $"CPU Info:\r\n{cpuInfo}\r\n\nMemory Info:\r\n{memInfo}";
        }

        // Save Device Info
        private void BtnSaveDeviceInfoToDB_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO DeviceInfoTable (CPUInfo, MemoryInfo) VALUES (@cpu, @mem)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    string[] parts = txtDeviceInfo.Text.Split(new[] { "\r\n\n" }, StringSplitOptions.None);
                    cmd.Parameters.AddWithValue("@cpu", parts[0].Replace("CPU Info:\r\n", ""));
                    cmd.Parameters.AddWithValue("@mem", parts.Length > 1 ? parts[1].Replace("Memory Info:\r\n", "") : "");
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Device info saved to DB.");
            }
        }

        // ADB command executor
        private string ExecuteAdbCommand(string command)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "adb",
                Arguments = command,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            using (Process process = Process.Start(psi))
            {
                return process.StandardOutput.ReadToEnd();
            }
        }

        // Parses ADB output into DataTable
        private DataTable ParseAdbOutput(string output, string[] columns)
        {
            DataTable table = new DataTable();
            foreach (string col in columns)
                table.Columns.Add(col);

            foreach (string line in output.Split(new[] { "Row " }, StringSplitOptions.RemoveEmptyEntries))
            {
                DataRow row = table.NewRow();
                foreach (string col in columns)
                {
                    int idx = line.IndexOf(col + "=");
                    if (idx != -1)
                    {
                        int start = idx + col.Length + 1;
                        int end = line.IndexOf(" ", start);
                        if (end == -1) end = line.Length;
                        row[col] = line.Substring(start, end - start).Trim();
                    }
                }
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
