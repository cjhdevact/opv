@echo off
echo.&echo 你确定要进行数字签名吗?任意键开始。 &PAUSE>nul
echo.&echo ***************************************************************
signtool.exe sign /f cert.pfx /t http://timestamp.digicert.com /fd SHA256 .\bin\Debug\opv.exe
echo.&echo ***************************************************************
echo.&echo 数字签名完成。任意键关闭窗口。 &PAUSE>nul