# Green Grey Ad Network SDK for Unity

## Текущая версия
1.0.5

## 0. Что понадобится для интеграции?
**GAME_ID** - идентификатор приложения в системе показа рекламы

**AD_SERVER_HOST** - адрес сервера рекламы

Их вы можете получить у менеджера Green Grey


## 1. Добавление в проект
1.1 В панели Package Manager выберите "Add package from git URL"

![Add package to project](/.readme/add_package_from_git.png)

1.2 В открывшемся окне вставьте ссылку https://github.com/GreenGreyStudioOfficial/AdNetworkSDK_release.git#v1.0.5

1.3 Для загрузки примера использования нужно в панели Package Manager выбрать AdNetworkSDK, в правой части развернуть список примеров и нажать кнопку “Import”

![Import samples](/.readme/import_samples.png)

1.4 После этого в проект будет добавлен пример использования SDK. Для его запуска необходимо прописать имеющиеся идентификаторы GAME_ID и AD_SERVER_HOST в верхней части файла LazyLoadExampleListener:


```
namespace GGADSDK.Samples.LazyLoadExample.Scripts
{
   public class LazyLoadExampleListener : MonoBehaviour, IAdInitializationListener, IAdLoadListener, IAdShowListener
   {
       private const string MY_GAME_ID = "MY_GAME_ID";
       private const string AD_SERVER_HOST = "AD_SERVER_HOST";

```


## 2. Дальнейшие шаги
Чтобы ознакомиться с подробностями устройства библиотеки и получить справку о работе отдельных методов можно в [документации на внутреннем портале](https://greengrey.atlassian.net/wiki/spaces/DEV/pages/183795734/GreenGrey.AdNetworkSDK)
