@echo off
color 0e
@echo ==================================
@echo ���ѣ����Ҽ����ļ����ù���Ա��ʽ�򿪡�
@echo ==================================
@echo Start Install SimpleAdmin.Background

cd ..
sc create SimpleAdmin.Background binPath=%~dp0SimpleAdmin.Background.exe start= auto 
sc description SimpleAdmin.Background "SimpleAdmin��̨����"
Net Start SimpleAdmin.Background
pause