using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;
// check it
namespace software_0
{
    public partial class Form1 : Form
    {
        private HubConnection connection;
        private readonly string clientUsername;

        public Form1()
        {
            InitializeComponent();
            clientUsername = $"Client-{Guid.NewGuid().ToString().Substring(0, 8)}"; // e.g., Client-a1b2c3d4
            ConnectToServer(); // Connect to SignalR server when the form loads
            this.txtUserInput.KeyDown += TxtUserInput_KeyDown; // Register the KeyDown event for the Enter key
        }

        // Display a message in the chat history
        private void DisplayMessage(string username, string message)
        {
            if (rtbChatHistory.InvokeRequired)
            {
                rtbChatHistory.Invoke(new Action(() =>
                {
                    rtbChatHistory.AppendText($"{username}: {message}\n");
                }));
            }
            else
            {
                rtbChatHistory.AppendText($"{username}: {message}\n");
            }
        }

        // Connect to the SignalR server
        private async void ConnectToServer()
        {
            connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/chatHub") // Replace with your SignalR server URL
                .Build();

            // Handle real-time messages
            connection.On<string, string, string>("ReceiveMessage", (username, message, senderConnectionId) =>
            {
                if (senderConnectionId != connection.ConnectionId)
                {
                    DisplayMessage(username, message);
                }
            });
            
            // Handle message history
            connection.On<List<Tuple<string, string>>>("ReceiveMessageHistory", (messages) =>
            {
                foreach (var (sender, message) in messages)
                {
                    DisplayMessage(sender, message);
                }
            });

            try
            {
                await connection.StartAsync();
                DisplayMessage("System", "Connected to chat server!");
            }
            catch (Exception ex)
            {
                DisplayMessage("System", $"Could not connect to server: {ex.Message}");
            }
        }

        // Handle the Send button click event to send a message
        private async void btnSend_Click(object sender, EventArgs e)
        {
            string userMessage = txtUserInput.Text.Trim();

            if (!string.IsNullOrEmpty(userMessage) && connection.State == HubConnectionState.Connected)
            {
                try
                {
                    // Send the message with the unique client username
                    await connection.InvokeAsync("SendMessage", clientUsername, userMessage);

                    // Display the message locally for the sender
                    DisplayMessage(clientUsername, userMessage);

                    txtUserInput.Clear();  // Clear the text input after sending
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending message: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Not connected to the server.");
            }
        }

        // Send a message when the Enter key is pressed
        private void TxtUserInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  // Check if the Enter key was pressed
            {
                btnSend_Click(this, EventArgs.Empty);  // Call the send button click method
                e.Handled = true;  // Prevent default behavior (e.g., a newline in the textbox)
                e.SuppressKeyPress = true;  // Suppress the Enter key press so it doesn't add a new line
            }
        }

        // Event handlers for other UI components (placeholders)

        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void ChatboxBorder_Paint(object sender, PaintEventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void txtUserInput_TextChanged(object sender, EventArgs e) { }
        private void ChatBox_Label_Click(object sender, EventArgs e) { }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e) { }
        private void Event_Click(object sender, EventArgs e) { }
        private void Memebrship_icon_Click(object sender, EventArgs e) { }
        private void Event_icon_Click(object sender, EventArgs e) { }
        private void Chat_icon_Click(object sender, EventArgs e) { }
        private void Home_icon_Click(object sender, EventArgs e) { }
        private void Profile_icon_Click(object sender, EventArgs e) { }
        private void Membership_Click(object sender, EventArgs e) { }
        private void rtbChatHistory_TextChanged(object sender, EventArgs e) { }
        private void ChatBox_Button_Click(object sender, EventArgs e) { }
        private void Home_Click(object sender, EventArgs e) { }
        private void Profile_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        
        
    }
}
