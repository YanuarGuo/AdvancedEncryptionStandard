# Advanced Encryption Standard (AES) Encryption & Decryption Tool

## Overview
This is a Windows Forms application that provides AES (Advanced Encryption Standard) encryption and decryption functionalities. It allows users to configure encryption settings, input plaintext and keys, and generate encrypted/decrypted output in different formats.

## Features
- Supports AES-128, AES-192, and AES-256 encryption.
- Configurable cipher modes: ECB, CBC, CFB, and OFB.
- Padding options: PKCS7 and ZeroPadding.
- Allows input of Initialization Vector (IV) in HEX or Base64 format.
- Supports output formats: Base64 and HEX.
- Key hashing option using SHA-256.
- User-friendly Windows Forms UI.

## Installation
1. Clone the repository or download the source code.
2. Open the project in Visual Studio.
3. Build and run the application.

## Usage
1. **Configure Encryption Settings**
   - Enter the encryption key.
   - Select the key size (AES-128, AES-192, or AES-256).
   - Choose the padding mode (PKCS7 or ZeroPadding).
   - Select the cipher mode (ECB, CBC, CFB, or OFB).
   - Input the IV (if required by the mode) in HEX or Base64 format.
   - Click "Confirm All" to save configurations.

2. **Encrypt Text**
   - Enter plaintext in the input field.
   - Click "Encrypt" to generate encrypted text.
   - The output will be displayed in the selected format (Base64 or HEX).

3. **Decrypt Text**
   - Enter ciphertext in the input field.
   - Click "Decrypt" to retrieve the original plaintext.

4. **Clear Fields**
   - "Clear Encryption" resets encryption inputs.
   - "Clear Decryption" resets decryption inputs.

## Code Overview
- **AES Encryption & Decryption**
  - `AESEncryption(...)` handles encryption logic.
  - `AESDecryption(...)` handles decryption logic.
- **Key and IV Handling**
  - `GenerateAESKey(...)` ensures the key is properly sized and hashed if required.
- **User Interface**
  - Implements Windows Forms UI components for easy configuration and execution.

## Dependencies
- .NET Framework (8.0 or higher)
- Windows Forms (System.Windows.Forms)
- System.Security.Cryptography for encryption functions

## Author
Developed by Yanuar Christy Ade Utama.

