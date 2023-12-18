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

        public static string CheckConflicts()
        {
            switch (GetLocale())
            {
                case Locale.ja_JP: return "インストールを続行した場合、一部のパッケージに不具合が発生する可能性があります。\n" +
                        "インストールを中断し、VCCを開いて下記のパッケージを更新してください：";
                default: return "If you continue with the installation, you may encounter problems with some packages.\n" +
                        "Please stop the installation, open VCC and update the following packages:";
            }
        }

        public static string CheckContinue()
        {
            switch (GetLocale())
            {
                case Locale.ja_JP: return "強制的にインストールを続行する場合は、「続行」を押してください。";
                default: return "To force the installation to continue, press \"Continue\".";
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

        public static string Confirm_AddPackages()
        {
            switch (GetLocale())
            {
                case Locale.ja_JP: return "下記のパッケージが新しくインストールされます：";
                default: return "You're newly installing the following packages:";
            }
        } 

        public static string Confirm_UpdatePackages()
        {
            switch (GetLocale())
            {
                case Locale.ja_JP: return "下記のパッケージが更新されます：";
                default: return "You're updating the following packages:";
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

        public static string IncompatibleWithCurrentUnity()
        {
            switch (GetLocale())
            {
                case Locale.ja_JP: return "下記のパッケージは、使用中のUnityのバージョンと互換性がありません！";
                default: return "The following packages are incompatible with current unity!";
            }
        } 

        public static string ChangeUnityVersion()
        {
            switch (GetLocale())
            {
                case Locale.ja_JP: return "パッケージをインストールする前に、Unityのバージョンを変更してください！";
                default: return "Please change unity version before installing packages!";
            }
        } 

        public static string OlderVrcSdkIsRequired()
        {
            switch (GetLocale())
            {
                case Locale.ja_JP: return "インストール対象のツールはUnity2019用のVRCSDKを必要としていますが、別のバージョンのVRCSDKを使用中のためツールをインストールできません。\n" +
                        "古いバージョンのVRCSDKを使用するか、ツールのアップデートをお待ちください。";
                default: return "You're installing tools that require VRCSDK for Unity 2019.x " +
                           "but you're using other versions of VRCSDK!\n" +
                           "Please use older VRCSDK or wait for tool updates!";
            }
        } 

        public static string UnityUpgradeIsRequired()
        {
            switch (GetLocale())
            {
                case Locale.ja_JP: return "Unityのアップグレードが必要です！";
                default: return "Unity upgrade is required!";
            }
        } 

        public static string Stop()
        {
            switch (GetLocale())
            {
                case Locale.ja_JP: return "中断";
                default: return "Stop";
            }
        }

        public static string Continue()
        {
            switch (GetLocale())
            {
                case Locale.ja_JP: return "続行";
                default: return "Continue";
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
