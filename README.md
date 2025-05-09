# Android Data Viewer

This is a Windows Forms application built with C# (.NET Framework) that retrieves and displays data from an Android device using ADB (Android Debug Bridge). It supports viewing Contacts, SMS, Call Logs, and Device Info from the connected Android device and storing this data in a SQL Server database.

## Features

- **View Contacts**: Displays contacts from the Android device in a DataGridView.
- **View SMS Messages**: Displays SMS messages in a DataGridView.
- **View Call Logs**: Displays call logs from the Android device.
- **View Device Info**: Displays device information, including CPU and memory details.
- **Save Data**: Allows saving the displayed data (Contacts, SMS, Device Info) to a SQL Server database.
- **Data Parsing**: Uses ADB commands to fetch data and parse it for display.

## Requirements

- .NET Framework 4.7.2 or higher
- ADB (Android Debug Bridge) installed on your computer
- SQL Server (any version) for storing data
- SQL Server Management Studio (SSMS) for database management
- Android device with USB Debugging enabled

## Setup


