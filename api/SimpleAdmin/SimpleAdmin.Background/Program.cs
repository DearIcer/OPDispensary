// SimpleAdmin ���� Apache License Version 2.0 Э�鷢������������ҵ��Ŀ���������������²�������:
// 1.�벻Ҫɾ�����޸ĸ�Ŀ¼�µ�LICENSE�ļ���
// 2.�벻Ҫɾ�����޸�SimpleAdminԴ��ͷ���İ�Ȩ������
// 3.�ַ�Դ��ʱ����ע��������� https://gitee.com/zxzyjs/SimpleAdmin
// 4.���ڱ��������Ʒ����ֻ��ʹ�� SimpleAdmin ��Ϊ��̨���񣬳���������������Ҳ�������ηַ���Դ��
// 5.�벻�ý������Ӧ����Σ�����Ұ�ȫ���������������Ϊ���������κ���ʽ���ڷǷ�ΪĿ�ĵ���Ϊ��Ҫɾ�����޸�����������
// 6.�κλ��ڱ������������һ�з��ɾ��׺����Σ�������˾�޹ء�

try
{
    Console.Title = "SimpleAdmin��̨����";
}
catch { }//ע�����ᱨ������Ҫcatch
Serve.Run(GenericRunOptions.Default
         .ConfigureBuilder(hostBuilder =>
        {
            hostBuilder.UseWindowsService();//֧��ע��ɷ���
            hostBuilder.ConfigureServices((hostContext, services) =>
            {
                services.AddMqttClientManager();//mqtt
            });
            return hostBuilder;
        })

);