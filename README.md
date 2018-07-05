byjg-service-examples
=====================

Aqui você encontrará vários exemplos de implementação dos serviços ByJG em diversas linguagens. 

Os Serviços ByJG públicos são
+ SMS - Serviço de envio de SMS por Web Service
+ CEP - Serviço de consulta de CEPs Brasileitos por Web Service

Navegar no código fonte
+ https://github.com/byjg/byjg-service-examples

Endereços:
+ Site Principal: http://www.byjg.com.br/
+ SMS Service: http://www.byjg.com.br/site/xmlnuke.php?xml=smswebservice
+ CEP Service: http://www.byjg.com.br/site/xmlnuke.php?xml=onlinecep
+ App Facebook: http://www.smswebservice.com.br/

O repositório com os exemplos é público e quem quiser ter acesso para incluir modificações basta se cadastrar no site e solicitar o acesso através do contato. 

Abaixo alguns exemplos:

### CSharp 

+ CEP + WebService
+ CEP + Post - Exemplo cedido gentilmento por Vitor Leal
+ SMS


#### Enviar SMS

```c#
var sms = new Sms(Usuario, Senha);

var resultCreditos = sms.Creditos();

Console.WriteLine("Creditos: ");
Console.WriteLine("---------------------------------------");
foreach (var credito in resultCreditos)
{
    Console.WriteLine("Disponivel: " + credito.Disponivel);
    Console.WriteLine("Validade: " + credito.Validade);
}
Console.WriteLine();

var resultSms = sms.EnviarSms("21", "123456789", "Essa é a mensagem");
Console.WriteLine("Result SMS: ");
Console.WriteLine("---------------------------------------");
Console.WriteLine(resultSms);
Console.WriteLine();

```

#### Consultar CEP


```c#
var cep = new Cep(Usuario, Senha);

var resultCep = cep.ObterLogradouro("20090-000");
Console.WriteLine("Result Obter Logradouro: ");
Console.WriteLine("---------------------------------------");
Console.WriteLine(string.Join(",", resultCep.ToString()));
Console.WriteLine();

var resultLogradouro = cep.ObterCep("Rio Branco", "Rio de Janeiro", "RJ");
Console.WriteLine("Result Obter Logradouro: ");
Console.WriteLine("---------------------------------------");
foreach (var logradouros in resultLogradouro)
{
    Console.WriteLine(logradouros.ToString());
}
Console.WriteLine();
```


### Delphi

+ CEP Example 1 - Exemplo cedido gentilmente por David Mengarda
+ CEP Example 2 (cód IBGE) - Exemplo cedido gentilmente por Andrea Kimura
+ SMS - Exemplo cedido gentilmente por Jonas Pneus, Gravataí / RS

### FoxPro

+ CEP - Exemplo cedido gentilmente por Graciano Santos Duarte

### HTML

+ CEP
+ CEP+JS

### Java

+ SMS
+ CEP

### Joomla

+ CEP - Exemplo cedido gentilmente por Ricardo Lima Caratti do Livro: "Joomla Avançado"
+ SMS - Exemplo cedido gentilmente pela Pixxis

### Objective C (IPhone)

+ CEP - Exemplo cedido gentilmente por Ricardo Lima Caratti do Livro: "Joomla Avançado 2dn Ed"

### PHP5

+ SMS
+ CEP - Exemplo cedido gentilmente por Deni Santos (NuSoap)
+ CEP - Exemplo cedido gentilmente por Marcio H V Pereira (Curl)

### SQL Server Intergration Service 11

+ CEP - Exemplo cedido gentilmento por Adauto Michelotti


### Visual Basic 6

+ CEP - Exemplo cedido gentilmente por Jorge Barros
+ CEP - Exemplo cedido gentilmente por Ari Benevenuto (SoapSDK)

### VB.Net

+ SMS

### xHarbour

+ SMS - Exemplo cedido gentilmente pela AWS Sistemas Empresarias, Sorocaba / SP
+ CEP - Exemplo cedido gentilmente por Leonardo Machado (1.0.1 Harbour + bcc51)



