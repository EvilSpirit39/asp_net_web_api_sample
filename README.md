# asp_net_web_api_sample
ASP.NETでWeb APIを作るサンプル

# 手順

## ツールのインストール
- aspnet-codegeneratorをインストール、アップデートしておく
  - `dotnet tool install -g dotnet-aspnet-codegenerator`
  - `dotnet tool update -g dotnet-aspnet-codegenerator`
## テンプレートからプロジェクトを作成
`dotnet new webapi` コマンドでテンプレートからプロジェクトを作成する。

## データベース関連のパッケージを追加

- データベースに対応したEntity Frameworkを追加  
  - `dotnet add package Microsoft.EntityFrameworkCore.SqlServer`
  - `dotnet add package Microsoft.EntityFrameworkCore.InMemory`
- aspnet-codegeneratorのパッケージを追加
  - `dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design`
  - `dotnet add package Microsoft.EntityFrameworkCore.Design`

## 開発用証明書を信頼
- `dotnet dev-certs https --trust` のコマンドで、開発用の証明書を信頼する。
- これにより、ローカル実行時のHTTPSアクセスが信頼される。


## モデルを追加

モデルを追加する。これはMVCの場合と同様

- `Models` ディレクトリ下にモデルを作成する

## コンテキストを作成
コンテキストを作成する。これもMVCの場合と同様

- `Models` ディレクトリ下に`DbContext` を継承したコンテキストを作り、プロパティとして`DbSet` を持たせる 

# 情報
## webapiテンプレートについて

- テンプレートから生成したデフォルトの状態では、`WeatherForecast` エンドポイントが実装されている。
- `swagger` エンドポイントにアクセスすると、Swagger UI が開け、OpenAPI仕様を見ることができる。
