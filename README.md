# Zalo .NET SDK

Zalo .NET SDK is a library that allows you to integrate Zalo features into your .NET application. This library provides a simple way to interact with Zalo APIs.

## Installation

You can install the SDK via NuGet Package Manager Console by running the following command:
```bash
Install-Package ZaloSDK
```

## Usage

### Initialize ZaloClient
```csharp
var zaloClient
	= new ZaloClient("your_app_id", "your_app_secret");
```

### Get OAuth URL
```csharp
var oauthUrl = zaloClient.GetOAuthUrl("your_redirect_uri");
```

### Get Access Token
```csharp
var accessToken = zaloClient.GetAccessToken("your_code", "your_redirect_uri");
```

### Get Profile
```csharp
var profile = zaloClient.GetProfile("your_access_token");
```

### Send Text Message
```csharp
var result = zaloClient.SendTextMessage("your_access_token", "your_recipient_id", "your_message");
```

### Send Image Message
```csharp
var result = zaloClient.SendImageMessage("your_access_token", "your_recipient_id", "your_message", "your_image_url");
```

### Send GIF Message
```csharp
var result = zaloClient.SendGifMessage("your_access_token", "your_recipient_id", "your_message", "your_gif_url");
```

### Send File Message
```csharp
var result = zaloClient.SendFileMessage("your_access_token", "your_recipient_id", "your_message", "your_file_url");
```

### Send List Message
```csharp
var result = zaloClient.SendListMessage("your_access_token", "your_recipient_id", "your_message", "your_list_element");
```

### Send Location Message
```csharp
var result = zaloClient.SendLocationMessage("your_access_token", "your_recipient_id", "your_message", "your_latitude", "your_longitude");
```

### Send Sticker Message
```csharp
var result = zaloClient.SendStickerMessage("your_access_token", "your_recipient_id", "your_message", "your_sticker_id");
```

### Send Template Message
```csharp
var result = zaloClient.SendTemplateMessage("your_access_token", "your_recipient_id", "your_message", "your_template");
```

### Send Action Message
```csharp
var result = zaloClient.SendActionMessage("your_access_token", "your_recipient_id", "your_message", "your_action");
```

### Send Open Graph Message
```csharp
var result = zaloClient.SendOpenGraphMessage("your_access_token", "your_recipient_id", "your_message", "your_open_graph");
```

### Send Receipt Message
```csharp
var result = zaloClient.SendReceiptMessage("your_access_token", "your_recipient_id", "your_message", "your_receipt");
```

### Send Request Message
```csharp
var result = zaloClient.SendRequestMessage("your_access_token", "your_recipient_id", "your_message", "your_request");
```

### Nuget Package

`dotnet pack -c Release`

`dotnet nuget push bin/Release/ZaloSDK.1.0.1.nupkg --api-key YOUR_API_KEY --source https://api.nuget.org/v3/index.json`