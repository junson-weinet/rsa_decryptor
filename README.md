# putty key pair general tutorial
# https://blog.csdn.net/xukai871105/article/details/46606903
# 注意只需要看前面4部

![save public key](https://github.com/junson-weinet/tutorial_images/blob/main/save_public_key.PNG?raw=true)
# 导出公钥

![export private key](https://github.com/junson-weinet/tutorial_images/blob/main/export_private_key.PNG?raw=true)
# 导出私钥

git clone https://github.com/junson-weinet/rsa_decryptor.git

cd rsa_decryptor

dotnet build rsa_decryptor.csproj

cd bin\Debug\net6.0

rsa_decryptor.exe r [pri_key_path] [encrypt_content]
output content