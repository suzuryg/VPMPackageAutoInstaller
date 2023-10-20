using System.Globalization;

namespace Anatawa12.VpmPackageAutoInstaller
{
    internal class Localization
    {
        public static string Error_Unknown()
        {
            switch (GetLocale())
            {
                case Locale.ja_JP: return "パッケージのインストール中にエラーが発生しました。";
                default: return "Error installing packages";
            }
        } 

        public static string Error_Conflict()
        {
            switch (GetLocale())
            {
                case Locale.ja_JP: return "下記のコンフリクトにより、パッケージのインストールに失敗しました：";
                default: return "Installing package failed due to conflicts:";
            }
        } 

        public static string SeeConsole()
        {
            switch (GetLocale())
            {
                case Locale.ja_JP: return "詳細についてはコンソールを確認してください。";
                default: return "Please see console for more details";
            }
        } 

        public static string NothingToDo()
        {
            switch (GetLocale())
            {
                case Locale.ja_JP: return "すべてのパッケージが既にインストールされています！";
                default: return "All Packages are Installed!";
            }
        } 

        public static string Confirm_Packages()
        {
            switch (GetLocale())
            {
                case Locale.ja_JP: return "下記のパッケージがインストールされます：";
                default: return "You're installing the following packages:";
            }
        } 

        public static string Confirm_Repositories()
        {
            switch (GetLocale())
            {
                case Locale.ja_JP: return "下記のリポジトリが追加されます：";
                default: return "This will add following repositories:";
            }
        } 

        public static string Confirm_LegacyFolders()
        {
            switch (GetLocale())
            {
                case Locale.ja_JP: return "下記のファイル／フォルダが削除されます：";
                default: return "You're also deleting the following files/folders:";
            }
        } 

        public static string Confirm_LegacyPackages()
        {
            switch (GetLocale())
            {
                case Locale.ja_JP: return "下記の古いパッケージが削除されます：";
                default: return "You're also deleting the following legacy Packages:";
            }
        } 

        public static string Install()
        {
            switch (GetLocale())
            {
                case Locale.ja_JP: return "インストール";
                default: return "Install";
            }
        } 

        public static string Cancel()
        {
            switch (GetLocale())
            {
                case Locale.ja_JP: return "キャンセル";
                default: return "Cancel";
            }
        } 

        private enum Locale
        {
            ja_JP,
            en_US,
        }

        private static Locale GetLocale()
        {
            var currentCulture = CultureInfo.CurrentUICulture;
            if (currentCulture.Name == "ja-JP")
            {
                return Locale.ja_JP;
            }
            else
            {
                return Locale.en_US;
            }
        }
    }
}
