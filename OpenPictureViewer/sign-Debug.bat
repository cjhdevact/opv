@echo off
echo.&echo ��ȷ��Ҫ��������ǩ����?�������ʼ�� &PAUSE>nul
echo.&echo ***************************************************************
signtool.exe sign /f cert.pfx /t http://timestamp.digicert.com /fd SHA256 .\bin\Debug\opv.exe
echo.&echo ***************************************************************
echo.&echo ����ǩ����ɡ�������رմ��ڡ� &PAUSE>nul