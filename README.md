# AdNetworkSDK
## Необходимые данные для подключения библиотеки
Токен авторизации для доступа к github репозиторию (далее <github_api_token>).

> Пример:
>
> ghp_sroeYEp9kOATCW3kQdzIpcs0jS5JTm07vHK

## Добавление библиотеки в проект
Добавление библиотеки возможно из приватного репозитория в пространстве GreenGreyStudioOfficial. Адрес состоит из трех частей:

- <github_api_token>
- путь до репозитория Github
- текущая версия библиотеки (ссылка на git tag релизного коммита)

> Пример:
>
> https://<**github_api_token**>@github.com/GreenGreyStudioOfficial/AdNetworkSDK_release.git#v<**current_version**>

Чтобы добавить зависимость в проект, нужно открыть **PROJECT_DIR/Packages/manifest.json** текущего проекта и добавить строчку в раздел "dependencies"

Пример:

```
  "dependencies": {
    ...,
    "com.greengreysoftworks.adnetworksdk": "https://ghp_sroeYEp9kOATCW3kQdzIpcs0jS5JTm07vHK@github.com/GreenGreyStudioOfficial/AdNetworkSDK_release.git#v1.0.1"
  }
```

## Использование библиотеки
Всю информацию по использованию библиотеки смотрите в [документации](https://greengrey.atlassian.net/wiki/spaces/DEV/pages/183795734/GreenGrey.AdNetworkSDK)
