# Whatsapp API C#

 Lightweight C# Code for WhatsApp API to send the whatsapp messages in PHP provided by wapify.netWapify C# API Client

# This repository contains a C# client for interfacing with the Wapify API. Seamlessly send text and media messages and create groups directly from your .NET applications.

# Features 🚀
Text Messaging: Effortlessly send text messages to users with a few lines of code.
Media Messaging: Attach media content via HTTPS links to deliver rich content.
Group Creation: Assemble users into groups for targeted messaging or other group-related operations.
# Prerequisites 📋
.NET Core SDK (at least version 3.1)
System.Net.Http namespace

# Send Message 
var response = await service.SendMessage("91xxxxxxxx", "Your Message");
Console.WriteLine(response);

# Send Media 
var response = await service.SendMediaMessage("91xxxxxxxx", "Your Message", "https://media-url.com/image.jpg");
Console.WriteLine(response);

# Create Group 
var response = await service.CreateGroup("91xxxxxxxx,91xxxxxxx", "My Group");
Console.WriteLine(response);
