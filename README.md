# Green Grey Ad Network SDK for Unity

## Текущая версия
1.1.1

## 0. Что понадобится для интеграции?
**GAME_ID** - идентификатор приложения в системе показа рекламы

Данную информацию вы можете получить у менеджера Green Grey


## 1. Добавление в проект
1.1 В панели Package Manager выберите "Add package from git URL"

![Add package to project](/.readme/add_package_from_git.png)

1.2 В открывшемся окне вставьте ссылку https://github.com/GreenGreyStudioOfficial/AdNetworkSDK_release.git#v1.1.0

1.3 Для загрузки примера использования нужно в панели Package Manager выбрать AdNetworkSDK, в правой части развернуть список примеров и нажать кнопку “Import”

![Import samples](/.readme/import_samples.png)

1.4 После этого в проект будет добавлен пример использования SDK. Для его запуска необходимо прописать имеющиеся идентификаторы GAME_ID в верхней части файла LoadExampleListener:


```
namespace GGADSDK.Samples.LazyLoadExample.Scripts
{
   public class LoadExampleListener : MonoBehaviour, IAdInitializationListener, IAdLoadListener, IAdShowListener
   {
       private const string MY_GAME_ID = "MY_GAME_ID";

```


## 2. Дальнейшие шаги
Чтобы ознакомиться с подробностями устройства библиотеки и получить справку о работе отдельных методов можно в [документации](https://github.com/GreenGreyStudioOfficial/ad-network-sdk-documentation)
