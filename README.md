# ���� Creekdream.AspNetCore ��ܵ�EntityFrameworkCoreʾ����Ŀ

��Ŀ��Ҫ���� Creekdream.AspNetCore ��ܿ���һ���򵥵Ķ��ܹ���ʾ����Ŀ��ʵ���˻�������ɾ�Ĳ����

## ��������

**����Ҫ��**
* VS2017
* SQLServer 2008+
* .NET CORE 2.1+
### 1. ���� SQLServer ��������

appsetting.json�������£�

``` csharp
{
  "ConnectionStrings": {
    "Default": "server=192.168.0.105;database=SimpleDemo;uid=sa;pwd=Sa123456"
  }
}
```

### 2. ʹ�� EFCore ����Ǩ�ƹ���������ݿ��ʼ��
``` csharp
// ��Ŀ����������ӳ�ʼ���ݿ��ļ���ִ�����������
Update-Database

// ����������������Ǩ���ļ���ɾ����ĿCreekdream.SimpleDemo.EntityFrameworkCore\�г�SeedData.cs������ļ�
Add-Migration InitializeDatabase
Update-Database
```

### 3. ������Ŀ������������ĵ������Բ�Ȳ�����