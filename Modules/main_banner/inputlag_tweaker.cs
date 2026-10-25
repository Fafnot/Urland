// Автоматически сгенерировано из inputlag.bat.
// Все значения реестра и команды взяты из исходного файла без изменений.
// ОС: только Windows.
using System.Collections.Generic;

public static partial class InputLagTweaker
{
    enum H { LM, CU }
    enum K { Dword, Str, Bin }
    record Reg(H Hive, string Path, string Name, K Kind, string Data);
    record Step(string Title, Reg[] Regs, string[] Cmds);

    static readonly Step[] WinSteps =
    {
        new("Выключение Миграции",
            new Reg[]
            {
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows\\DeviceGuard", "HVCIMATRequired", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\kernel", "DisableExceptionChainValidation", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\kernel", "KernelSEHOPEnabled", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "EnableCfg", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Session Manager", "ProtectionMode", K.Dword, "0"),
            },
            new string[]
            {
            }),
        new("Применение настроек NTFS",
            new Reg[]
            {
            },
            new string[]
            {
                "fsutil behavior set memoryusage 2",
                "fsutil behavior set mftzone 4",
                "fsutil behavior set disablelastaccess 1",
                "fsutil behavior set disabledeletenotify 0",
                "fsutil behavior set encryptpagingfile 0",
            }),
        new("Отключение сжатия памяти",
            new Reg[]
            {
            },
            new string[]
            {
                "PowerShell -Command \"Disable-MMAgent -MemoryCompression\"",
            }),
        new("Настройка Win32Priority",
            new Reg[]
            {
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\PriorityControl", "Win32PrioritySeparation", K.Dword, "38"),
            },
            new string[]
            {
            }),
        new("Включаем Large System Cache",
            new Reg[]
            {
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "LargeSystemCache", K.Dword, "1"),
            },
            new string[]
            {
            }),
        new("Включаем Быстрый Запуск",
            new Reg[]
            {
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Power", "HiberbootEnabled", K.Dword, "1"),
            },
            new string[]
            {
            }),
        new("Отключение Гибернации",
            new Reg[]
            {
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "HibernateEnabled", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "SleepReliabilityDetailedDiagnostics", K.Dword, "0"),
            },
            new string[]
            {
                "powercfg /h off",
            }),
        new("Отключение режима сна",
            new Reg[]
            {
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Power", "SleepStudyDisabled", K.Dword, "1"),
            },
            new string[]
            {
            }),
        new("Отключение автоматического обслуживания",
            new Reg[]
            {
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule\\Maintenance", "MaintenanceDisabled", K.Dword, "1"),
            },
            new string[]
            {
            }),
        new("Отключение управления подкачкой",
            new Reg[]
            {
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "DisablePagingExecutive", K.Dword, "1"),
            },
            new string[]
            {
            }),
        new("Отключение Power Throttling",
            new Reg[]
            {
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Session Manager", "CoalescingTimerInterval", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Power", "CoalescingTimerInterval", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "CoalescingTimerInterval", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\kernel", "CoalescingTimerInterval", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Executive", "CoalescingTimerInterval", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power\\ModernSleep", "CoalescingTimerInterval", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "CoalescingTimerInterval", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "PlatformAoAcOverride", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "EnergyEstimationEnabled", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "EventProcessorEnabled", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "CsEnabled", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power\\PowerThrottling", "PowerThrottlingOff", K.Dword, "1"),
            },
            new string[]
            {
            }),
        new("Включаем HAGS",
            new Reg[]
            {
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", "HwSchMode", K.Dword, "2"),
            },
            new string[]
            {
            }),
        new("Включение распределения таймеров",
            new Reg[]
            {
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\kernel", "DistributeTimers", K.Dword, "1"),
            },
            new string[]
            {
            }),
        new("Отключение драйвера энергопотребления графического процессора",
            new Reg[]
            {
                new(H.LM, "SYSTEM\\CurrentControlSet\\Services\\GpuEnergyDrv", "Start", K.Dword, "4"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Services\\GpuEnergyDr", "Start", K.Dword, "4"),
            },
            new string[]
            {
            }),
        new("Отключение регистрации энергопотребления",
            new Reg[]
            {
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power\\EnergyEstimation\\TaggedEnergy", "DisableTaggedEnergyLogging", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power\\EnergyEstimation\\TaggedEnergy", "TelemetryMaxApplication", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power\\EnergyEstimation\\TaggedEnergy", "TelemetryMaxTagPerApplication", K.Dword, "0"),
            },
            new string[]
            {
            }),
        new("Отключение экспериментов Windows Insider",
            new Reg[]
            {
                new(H.LM, "SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\System", "AllowExperimentation", K.Dword, "0"),
                new(H.LM, "SOFTWARE\\Microsoft\\PolicyManager\\default\\System\\AllowExperimentation", "value", K.Dword, "0"),
            },
            new string[]
            {
            }),
        new("Настройка для Игр",
            new Reg[]
            {
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "NoLazyMode", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "AlwaysOn", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "GPU Priority", K.Dword, "8"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Priority", K.Dword, "6"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Scheduling Category", K.Str, "High"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "SFIO Priority", K.Str, "High"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Latency Sensitive", K.Str, "True"),
            },
            new string[]
            {
            }),
        new("Отключение задержки контекстного меню",
            new Reg[]
            {
                new(H.CU, "Control Panel\\Desktop", "MenuShowDelay", K.Str, "0"),
            },
            new string[]
            {
            }),
        new("Установка интервала между отметками времени",
            new Reg[]
            {
                new(H.LM, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Reliability", "TimeStampInterval", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Reliability", "IoPriority", K.Dword, "3"),
            },
            new string[]
            {
            }),
        new("Настройка CSRSS в реальном времени",
            new Reg[]
            {
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\csrss.exe\\PerfOptions", "CpuPriorityClass", K.Dword, "4"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\csrss.exe\\PerfOptions", "IoPriority", K.Dword, "3"),
            },
            new string[]
            {
            }),
        new("Настройка System Responsiveness",
            new Reg[]
            {
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", K.Dword, "0"),
            },
            new string[]
            {
            }),
        new("Настройка Network Throttling Index",
            new Reg[]
            {
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "NetworkThrottlingIndex", K.Dword, "10"),
            },
            new string[]
            {
            }),
        new("Отключение совместного использования",
            new Reg[]
            {
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CDP", "CdpSessionUserAuthzPolicy", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CDP", "NearShareChannelUserAuthzPolicy", K.Dword, "0"),
            },
            new string[]
            {
            }),
        new("Отключение частых / последних файлов",
            new Reg[]
            {
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer", "ShowFrequent", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer", "ShowRecent", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer", "TelemetrySalt", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoRecentDocsHistory", K.Dword, "1"),
            },
            new string[]
            {
            }),
        new("Отключение адаптированных событий",
            new Reg[]
            {
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Privacy", "TailoredExperiencesWithDiagnosticDataEnabled", K.Dword, "0"),
            },
            new string[]
            {
            }),
        new("Отключение логов поиска",
            new Reg[]
            {
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Search", "HistoryViewEnabled", K.Dword, "0"),
            },
            new string[]
            {
            }),
        new("Отключение поиска в Bing",
            new Reg[]
            {
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Search", "DeviceHistoryEnabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Search", "BingSearchEnabled", K.Dword, "0"),
            },
            new string[]
            {
            }),
    };

    static readonly Step[] PushSteps =
    {
        new("Отключение уведомлений",
            new Reg[]
            {
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\PushNotifications", "ToastEnabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Notifications\\Settings", "NOC_GLOBAL_SETTING_ALLOW_NOTIFICATION_SOUND", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Notifications\\Settings", "NOC_GLOBAL_SETTING_ALLOW_CRITICAL_TOASTS_ABOVE_LOCK", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Notifications\\Settings\\QuietHours", "Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Notifications\\Settings\\windows.immersivecontrolpanel_cw5n1h2txyewy!microsoft.windows.immersivecontrolpanel", "Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Notifications\\Settings\\Windows.SystemToast.AutoPlay", "Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Notifications\\Settings\\Windows.SystemToast.LowDisk", "Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Notifications\\Settings\\Windows.SystemToast.Print.Notification", "Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Notifications\\Settings\\Windows.SystemToast.SecurityAndMaintenance", "Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Notifications\\Settings\\Windows.SystemToast.WiFiNetworkManager", "Enabled", K.Dword, "0"),
            },
            new string[]
            {
            }),
    };

    static readonly Step[] CapabilitySteps =
    {
        new("Настройка параметров конфиденциальности Windows",
            new Reg[]
            {
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\activity", "Value", K.Str, "Deny"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\appDiagnostics", "Value", K.Str, "Deny"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\appointments", "Value", K.Str, "Deny"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\bluetoothSync", "Value", K.Str, "Deny"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\broadFileSystemAccess", "Value", K.Str, "Deny"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\cellularData", "Value", K.Str, "Deny"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\cellularData\\Microsoft.Win32WebViewHost_cw5n1h2txyewy", "Value", K.Str, "Allow"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\chat", "Value", K.Str, "Deny"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\contacts", "Value", K.Str, "Deny"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\documentsLibrary", "Value", K.Str, "Deny"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\email", "Value", K.Str, "Deny"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\gazeInput", "Value", K.Str, "Deny"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\location", "Value", K.Str, "Deny"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\location\\Microsoft.Win32WebViewHost_cw5n1h2txyewy", "Value", K.Str, "Prompt"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\microphone", "Value", K.Str, "Allow"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\microphone\\Microsoft.Win32WebViewHost_cw5n1h2txyewy", "Value", K.Str, "Prompt"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\phoneCall", "Value", K.Str, "Deny"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\phoneCallHistory", "Value", K.Str, "Deny"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\picturesLibrary", "Value", K.Str, "Deny"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\radios", "Value", K.Str, "Deny"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userAccountInformation", "Value", K.Str, "Deny"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userAccountInformation\\Microsoft.AccountsControl_cw5n1h2txyewy", "Value", K.Str, "Prompt"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userDataTasks", "Value", K.Str, "Deny"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userNotificationListener", "Value", K.Str, "Deny"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\videosLibrary", "Value", K.Str, "Deny"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\webcam", "Value", K.Str, "Allow"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\webcam\\Microsoft.Win32WebViewHost_cw5n1h2txyewy", "Value", K.Str, "Allow"),
            },
            new string[]
            {
            }),
    };

    static readonly Step[] ContentDeliverySteps =
    {
        new("Предложения по отключению сведений Windows",
            new Reg[]
            {
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SystemPaneSuggestionsEnabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-338388Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-314559Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-280815Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-314563Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-338393Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-353694Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-353696Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-310093Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-202914Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-338387Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-338389Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-353698Enabled", K.Dword, "0"),
            },
            new string[]
            {
            }),
    };

    static readonly Step[] StartupSteps =
    {
        new("Отключение автозагрузки приложений",
            new Reg[]
            {
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\StartupApproved\\Run", "Discord", K.Bin, "0300000066AF9C7C5A46D901"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\StartupApproved\\Run", "Synapse3", K.Bin, "030000007DC437B0EA9FD901"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\StartupApproved\\Run", "Spotify", K.Bin, "0300000070E93D7B5A46D901"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\StartupApproved\\Run", "EpicGamesLauncher", K.Bin, "03000000F51C70A77A48D901"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\StartupApproved\\Run", "RiotClient", K.Bin, "03000000A0EA598A88B2D901"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\StartupApproved\\Run", "Steam", K.Bin, "03000000E7766B83316FD901"),
            },
            new string[]
            {
            }),
    };

    static readonly Step[] AccessibilitySteps =
    {
        new("Отключение синхронизации настроек",
            new Reg[]
            {
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SettingSync\\Groups\\Accessibility", "Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SettingSync\\Groups\\AppSync", "Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SettingSync\\Groups\\BrowserSettings", "Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SettingSync\\Groups\\Credentials", "Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SettingSync\\Groups\\DesktopTheme", "Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SettingSync\\Groups\\Language", "Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SettingSync\\Groups\\PackageState", "Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SettingSync\\Groups\\Personalization", "Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SettingSync\\Groups\\StartLayout", "Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SettingSync\\Groups\\Windows", "Enabled", K.Dword, "0"),
            },
            new string[]
            {
            }),
        new("Отключение отчетов об ошибках Windows",
            new Reg[]
            {
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Error Reporting", "Disabled", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Error Reporting", "DoReport", K.Dword, "0"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Error Reporting", "LoggingDisabled", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\PCHealth\\ErrorReporting", "DoReport", K.Dword, "0"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows\\Windows Error Reporting", "Disabled", K.Dword, "1"),
            },
            new string[]
            {
            }),
        new("Определение приоритетов обслуживания",
            new Reg[]
            {
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\I/O System", "PassiveIntRealTimeWorkerPriority", K.Dword, "18"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\KernelVelocity", "DisableFGBoostDecay", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\dwm.exe\\PerfOptions", "CpuPriorityClass", K.Dword, "4"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\dwm.exe\\PerfOptions", "IoPriority", K.Dword, "3"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\lsass.exe\\PerfOptions", "CpuPriorityClass", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\lsass.exe\\PerfOptions", "IoPriority", K.Dword, "0"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\lsass.exe\\PerfOptions", "PagePriority", K.Dword, "0"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\ntoskrnl.exe\\PerfOptions", "CpuPriorityClass", K.Dword, "4"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\ntoskrnl.exe\\PerfOptions", "IoPriority", K.Dword, "3"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\SearchIndexer.exe\\PerfOptions", "CpuPriorityClass", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\SearchIndexer.exe\\PerfOptions", "IoPriority", K.Dword, "0"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\svchost.exe\\PerfOptions", "CpuPriorityClass", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\TrustedInstaller.exe\\PerfOptions", "CpuPriorityClass", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\TrustedInstaller.exe\\PerfOptions", "IoPriority", K.Dword, "0"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\wuauclt.exe\\PerfOptions", "CpuPriorityClass", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\wuauclt.exe\\PerfOptions", "IoPriority", K.Dword, "0"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\audiodg.exe\\PerfOptions", "CpuPriorityClass", K.Dword, "2"),
                new(H.LM, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\audiodg.exe\\PerfOptions", "CpuPriorityClass", K.Dword, "2"),
                new(H.LM, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\dwm.exe\\PerfOptions", "CpuPriorityClass", K.Dword, "4"),
                new(H.LM, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\dwm.exe\\PerfOptions", "IoPriority", K.Dword, "3"),
                new(H.LM, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\lsass.exe\\PerfOptions", "CpuPriorityClass", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\lsass.exe\\PerfOptions", "IoPriority", K.Dword, "0"),
                new(H.LM, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\lsass.exe\\PerfOptions", "PagePriority", K.Dword, "0"),
                new(H.LM, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\ntoskrnl.exe\\PerfOptions", "CpuPriorityClass", K.Dword, "4"),
                new(H.LM, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\ntoskrnl.exe\\PerfOptions", "IoPriority", K.Dword, "3"),
                new(H.LM, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\SearchIndexer.exe\\PerfOptions", "CpuPriorityClass", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\SearchIndexer.exe\\PerfOptions", "IoPriority", K.Dword, "0"),
                new(H.LM, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\svchost.exe\\PerfOptions", "CpuPriorityClass", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\TrustedInstaller.exe\\PerfOptions", "CpuPriorityClass", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\TrustedInstaller.exe\\PerfOptions", "IoPriority", K.Dword, "0"),
                new(H.LM, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\wuauclt.exe\\PerfOptions", "CpuPriorityClass", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\wuauclt.exe\\PerfOptions", "IoPriority", K.Dword, "0"),
            },
            new string[]
            {
            }),
    };

    static readonly Step[] DefenderSteps =
    {
        new("Отключение защитника Windows",
            new Reg[]
            {
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Reporting", "DisableGenericReports", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "LocalSettingOverrideSpynetReporting", K.Dword, "0"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "SpynetReporting", K.Dword, "0"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "SubmitSamplesConsent", K.Dword, "2"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows Defender\\SmartScreen", "ConfigureAppInstallControlEnabled", K.Dword, "0"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Threats", "Threats_ThreatSeverityDefaultAction", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Threats\\ThreatSeverityDefaultAction", "1", K.Str, "6"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Threats\\ThreatSeverityDefaultAction", "2", K.Str, "6"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Threats\\ThreatSeverityDefaultAction", "4", K.Str, "6"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Threats\\ThreatSeverityDefaultAction", "5", K.Str, "6"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows Defender\\UX Configuration", "Notification_Suppress", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Services\\Sense", "Start", K.Dword, "4"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Services\\WdNisSvc", "Start", K.Dword, "4"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Services\\WinDefend", "Start", K.Dword, "4"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Services\\SecurityHealthService", "Start", K.Dword, "4"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Services\\wscsvc", "Start", K.Dword, "4"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRoutinelyTakingAction", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows Defender", "ServiceKeepAlive", K.Dword, "0"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableIOAVProtection", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Reporting", "DisableEnhancedNotifications", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows Defender Security Center\\Notifications", "DisableNotifications", K.Dword, "1"),
                new(H.CU, "SOFTWARE\\Policies\\Microsoft\\Windows\\CurrentVersion\\PushNotifications", "NoToastApplicationNotification", K.Dword, "1"),
                new(H.CU, "SOFTWARE\\Policies\\Microsoft\\Windows\\CurrentVersion\\PushNotifications", "NoToastApplicationNotificationOnLockScreen", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\MsMpEng.exe\\PerfOptions", "CpuPriorityClass", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\MsMpEngCP.exe\\PerfOptions", "CpuPriorityClass", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\MRT", "DontReportInfectionInformation", K.Dword, "1"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows\\System", "EnableSmartScreen", K.Dword, "0"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\MicrosoftEdge\\PhishingFilter", "EnabledV9", K.Dword, "0"),
            },
            new string[]
            {
            }),
    };

    static readonly Step[] FseSteps =
    {
        new("Включение полноэкранной оптимизации",
            new Reg[]
            {
                new(H.CU, "System\\GameConfigStore", "GameDVR_DSEBehavior", K.Dword, "2"),
                new(H.CU, "System\\GameConfigStore", "GameDVR_DXGIHonorFSEWindowsCompatible", K.Dword, "1"),
                new(H.CU, "System\\GameConfigStore", "GameDVR_EFSEFeatureFlags", K.Dword, "0"),
                new(H.CU, "System\\GameConfigStore", "GameDVR_FSEBehavior", K.Dword, "2"),
                new(H.CU, "System\\GameConfigStore", "GameDVR_FSEBehaviorMode", K.Dword, "2"),
                new(H.CU, "System\\GameConfigStore", "GameDVR_HonorUserFSEBehaviorMode", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Environment", "__COMPAT_LAYER", K.Str, "~ DISABLEDXMAXIMIZEDWINDOWEDMODE"),
                new(H.CU, "System\\GameBar", "GamePanelStartupTipIndex", K.Dword, "3"),
                new(H.CU, "System\\GameBar", "ShowStartupPanel", K.Dword, "0"),
                new(H.CU, "System\\GameBar", "UseNexusForGameBarEnabled", K.Dword, "0"),
                new(H.LM, "SOFTWARE\\Microsoft\\WindowsRuntime\\ActivatableClassId\\Windows.Gaming.GameBar.PresenceServer.Internal.PresenceWriter", "ActivationType", K.Dword, "0"),
                new(H.LM, "SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR", "AllowGameDVR", K.Dword, "0"),
                new(H.LM, "SOFTWARE\\Microsoft\\PolicyManager\\default\\ApplicationManagement\\AllowGameDVR", "value", K.Dword, "0"),
                new(H.CU, "System\\GameConfigStore", "GameDVR_Enabled", K.Dword, "0"),
                new(H.CU, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\GameDVR", "AppCaptureEnabled", K.Dword, "0"),
            },
            new string[]
            {
            }),
        new("Настройка допуска задержки",
            new Reg[]
            {
                new(H.LM, "SYSTEM\\CurrentControlSet\\Services\\DXGKrnl", "MonitorLatencyTolerance", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Services\\DXGKrnl", "MonitorRefreshLatencyTolerance", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "ExitLatency", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "ExitLatencyCheckEnabled", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "Latency", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "LatencyToleranceDefault", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "LatencyToleranceFSVP", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "LatencyTolerancePerfOverride", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "LatencyToleranceScreenOffIR", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "LatencyToleranceVSyncEnabled", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "RtlCapabilityCheckLatency", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "DefaultD3TransitionLatencyActivelyUsed", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "DefaultD3TransitionLatencyIdleLongTime", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "DefaultD3TransitionLatencyIdleMonitorOff", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "DefaultD3TransitionLatencyIdleNoContext", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "DefaultD3TransitionLatencyIdleShortTime", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "DefaultD3TransitionLatencyIdleVeryLongTime", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "DefaultLatencyToleranceIdle0", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "DefaultLatencyToleranceIdle0MonitorOff", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "DefaultLatencyToleranceIdle1", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "DefaultLatencyToleranceIdle1MonitorOff", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "DefaultLatencyToleranceMemory", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "DefaultLatencyToleranceNoContext", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "DefaultLatencyToleranceNoContextMonitorOff", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "DefaultLatencyToleranceOther", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "DefaultLatencyToleranceTimerPeriod", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "DefaultMemoryRefreshLatencyToleranceActivelyUsed", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "DefaultMemoryRefreshLatencyToleranceMonitorOff", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "DefaultMemoryRefreshLatencyToleranceNoContext", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "Latency", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "MaxIAverageGraphicsLatencyInOneBucket", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "MiracastPerfTrackGraphicsLatency", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "MonitorLatencyTolerance", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "MonitorRefreshLatencyTolerance", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Power", "TransitionLatency", K.Dword, "1"),
            },
            new string[]
            {
            }),
        new("Настройка значений хранилища политики ресурсов",
            new Reg[]
            {
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\CPU\\HardCap0", "CapPercentage", K.Dword, "0"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\CPU\\HardCap0", "SchedulingType", K.Dword, "0"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\CPU\\Paused", "CapPercentage", K.Dword, "0"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\CPU\\Paused", "SchedulingType", K.Dword, "0"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\CPU\\SoftCapFull", "CapPercentage", K.Dword, "0"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\CPU\\SoftCapFull", "SchedulingType", K.Dword, "0"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\CPU\\SoftCapLow", "CapPercentage", K.Dword, "0"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\CPU\\SoftCapLow", "SchedulingType", K.Dword, "0"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Flags\\BackgroundDefault", "IsLowPriority", K.Dword, "0"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Flags\\Frozen", "IsLowPriority", K.Dword, "0"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Flags\\FrozenDNCS", "IsLowPriority", K.Dword, "0"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Flags\\FrozenDNK", "IsLowPriority", K.Dword, "0"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Flags\\FrozenPPLE", "IsLowPriority", K.Dword, "0"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Flags\\Paused", "IsLowPriority", K.Dword, "0"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Flags\\PausedDNK", "IsLowPriority", K.Dword, "0"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Flags\\Pausing", "IsLowPriority", K.Dword, "0"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Flags\\PrelaunchForeground", "IsLowPriority", K.Dword, "0"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Flags\\ThrottleGPUInterference", "IsLowPriority", K.Dword, "0"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\Critical", "BasePriority", K.Dword, "82"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\Critical", "OverTargetPriority", K.Dword, "50"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\CriticalNoUi", "BasePriority", K.Dword, "82"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\CriticalNoUi", "OverTargetPriority", K.Dword, "50"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\EmptyHostPPLE", "BasePriority", K.Dword, "82"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\EmptyHostPPLE", "OverTargetPriority", K.Dword, "50"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\High", "BasePriority", K.Dword, "82"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\High", "OverTargetPriority", K.Dword, "50"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\Low", "BasePriority", K.Dword, "82"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\Low", "OverTargetPriority", K.Dword, "50"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\Lowest", "BasePriority", K.Dword, "82"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\Lowest", "OverTargetPriority", K.Dword, "50"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\Medium", "BasePriority", K.Dword, "82"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\Medium", "OverTargetPriority", K.Dword, "50"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\MediumHigh", "BasePriority", K.Dword, "82"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\MediumHigh", "OverTargetPriority", K.Dword, "50"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\StartHost", "BasePriority", K.Dword, "82"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\StartHost", "OverTargetPriority", K.Dword, "50"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\VeryHigh", "BasePriority", K.Dword, "82"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\VeryHigh", "OverTargetPriority", K.Dword, "50"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\VeryLow", "BasePriority", K.Dword, "82"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Importance\\VeryLow", "OverTargetPriority", K.Dword, "50"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\IO\\NoCap", "IOBandwidth", K.Dword, "0"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Memory\\NoCap", "CommitLimit", K.Dword, "4294967295"),
                new(H.LM, "SYSTEM\\ResourcePolicyStore\\ResourceSets\\Policies\\Memory\\NoCap", "CommitTarget", K.Dword, "4294967295"),
            },
            new string[]
            {
            }),
    };

    static readonly Step[] NvidiaGuidSteps =
    {
        new("Шучу, просто нормально ша сделаю :)",
            new Reg[]
            {
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "D3PCLatency", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "F1TransitionLatency", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "LOWLATENCY", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "Node3DLowLatency", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "PciLatencyTimerControl", K.Dword, "20"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "RMDeepL1EntryLatencyUsec", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "RmGspcMaxFtuS", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "RmGspcMinFtuS", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "RmGspcPerioduS", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "RMLpwrEiIdleThresholdUs", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "RMLpwrGrIdleThresholdUs", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "RMLpwrGrRgIdleThresholdUs", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "RMLpwrMsIdleThresholdUs", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "VRDirectFlipDPCDelayUs", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "VRDirectFlipTimingMarginUs", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "VRDirectJITFlipMsHybridFlipDelayUs", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "vrrCursorMarginUs", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "vrrDeflickerMarginUs", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "vrrDeflickerMaxUs", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "ExitLatency", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "ExitLatencyCheckEnabled", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "Latency", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "LatencyToleranceDefault", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "LatencyToleranceFSVP", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "LatencyTolerancePerfOverride", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "LatencyToleranceScreenOffIR", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "LatencyToleranceVSyncEnabled", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "RtlCapabilityCheckLatency", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "QosManagesIdleProcessors", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "DisableVsyncLatencyUpdate", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "DisableSensorWatchdog", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "CoalescingTimerInterval", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "InterruptSteeringDisabled", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "LowLatencyScalingPercentage", K.Dword, "100"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "HighPerformance", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "HighestPerformance", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "MinimumThrottlePercent", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "MaximumThrottlePercent", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "MaximumPerformancePercent", K.Dword, "100"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "InitialUnparkCount", K.Dword, "100"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "DefaultD3TransitionLatencyActivelyUsed", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "DefaultD3TransitionLatencyIdleLongTime", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "DefaultD3TransitionLatencyIdleMonitorOff", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "DefaultD3TransitionLatencyIdleNoContext", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "DefaultD3TransitionLatencyIdleShortTime", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "DefaultD3TransitionLatencyIdleVeryLongTime", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "DefaultLatencyToleranceIdle0", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "DefaultLatencyToleranceIdle0MonitorOff", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "DefaultLatencyToleranceIdle1", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "DefaultLatencyToleranceIdle1MonitorOff", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "DefaultLatencyToleranceMemory", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "DefaultLatencyToleranceNoContext", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "DefaultLatencyToleranceNoContextMonitorOff", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "DefaultLatencyToleranceOther", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "DefaultLatencyToleranceTimerPeriod", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "DefaultMemoryRefreshLatencyToleranceActivelyUsed", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "DefaultMemoryRefreshLatencyToleranceMonitorOff", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "DefaultMemoryRefreshLatencyToleranceNoContext", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "Latency", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "MaxIAverageGraphicsLatencyInOneBucket", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "MiracastPerfTrackGraphicsLatency", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "MonitorLatencyTolerance", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "MonitorRefreshLatencyTolerance", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "TransitionLatency", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Power", "EnablePreemption", K.Dword, "0"),
            },
            new string[]
            {
            }),
    };

    static readonly Step[] AmdSteps =
    {
        new("Применение Твиков AMD...",
            new Reg[]
            {
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "NotifySubscription", K.Bin, "3000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "IsComponentControl", K.Bin, "00000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "KMD_USUEnable", K.Dword, "0"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "KMD_RadeonBoostEnabled", K.Dword, "0"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "IsAutoDefault", K.Bin, "01000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "KMD_ChillEnabled", K.Dword, "0"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "KMD_DeLagEnabled", K.Dword, "0"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "ACE", K.Bin, "3000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "AnisoDegree_SET", K.Bin, "3020322034203820313600"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "Main3D_SET", K.Bin, "302031203220332034203500"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "Tessellation_OPTION", K.Bin, "3200"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "Tessellation", K.Bin, "3100"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "AAF", K.Bin, "30000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "GI", K.Bin, "31000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "CatalystAI", K.Bin, "31000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "TemporalAAMultiplier_NA", K.Bin, "3100"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "ForceZBufferDepth", K.Bin, "30000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "EnableTripleBuffering", K.Bin, "3000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "ExportCompressedTex", K.Bin, "31000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "PixelCenter", K.Bin, "30000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "ZFormats_NA", K.Bin, "3100"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "DitherAlpha_NA", K.Bin, "3100"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "SwapEffect_D3D_SET", K.Bin, "3020312032203320342038203900"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "TFQ", K.Bin, "3200"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "VSyncControl", K.Bin, "3100"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "TextureOpt", K.Bin, "30000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "TextureLod", K.Bin, "30000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "ASE", K.Bin, "3000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "ASD", K.Bin, "3000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "ASTT", K.Bin, "3000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "AntiAliasSamples", K.Bin, "3000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "AntiAlias", K.Bin, "3100"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "AnisoDegree", K.Bin, "3000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "AnisoType", K.Bin, "30000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "AntiAliasMapping_SET", K.Bin, "3028303A302C313A3029203228303A322C313A3229203428303A342C313A3429203828303A382C313A382900"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "AntiAliasSamples_SET", K.Bin, "3020322034203800"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "ForceZBufferDepth_SET", K.Bin, "3020313620323400"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "SwapEffect_OGL_SET", K.Bin, "3020312032203320342035203620372038203920313120313220313320313420313520313620313700"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "Tessellation_SET", K.Bin, "31203220342036203820313620333220363400"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "HighQualityAF", K.Bin, "3100"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "DisplayCrossfireLogo", K.Bin, "3000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "AppGpuId", K.Bin, "300078003000310030003000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "SwapEffect", K.Bin, "30000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "PowerState", K.Bin, "3000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "AntiStuttering", K.Bin, "3100"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "TurboSync", K.Bin, "3000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "SurfaceFormatReplacements", K.Bin, "3100"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "EQAA", K.Bin, "3000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "ShaderCache", K.Bin, "3100"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "MLF", K.Bin, "3000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "TruformMode_NA", K.Bin, "3100"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "LRTCEnable", K.Bin, "30000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "3to2Pulldown", K.Bin, "31000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "MosquitoNoiseRemoval_ENABLE", K.Bin, "30000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "MosquitoNoiseRemoval", K.Bin, "350030000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "Deblocking_ENABLE", K.Bin, "30000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "Deblocking", K.Bin, "350030000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "DemoMode", K.Bin, "30000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "OverridePA", K.Bin, "30000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "DynamicRange", K.Bin, "30000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "StaticGamma_ENABLE", K.Bin, "30000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "BlueStretch_ENABLE", K.Bin, "31000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "BlueStretch", K.Bin, "31000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "LRTCCoef", K.Bin, "3100300030000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "DynamicContrast_ENABLE", K.Bin, "30000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "WhiteBalanceCorrection", K.Bin, "30000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "Fleshtone_ENABLE", K.Bin, "30000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "Fleshtone", K.Bin, "350030000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "ColorVibrance_ENABLE", K.Bin, "31000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "ColorVibrance", K.Bin, "340030000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "Detail_ENABLE", K.Bin, "30000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "Detail", K.Bin, "310030000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "Denoise_ENABLE", K.Bin, "30000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "Denoise", K.Bin, "360034000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "TrueWhite", K.Bin, "30000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "OvlTheaterMode", K.Bin, "30000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "StaticGamma", K.Bin, "3100300030000000"),
                new(H.LM, "System\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD\\DXVA", "InternetVideo", K.Bin, "30000000"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "Main3D_DEF", K.Str, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000\\UMD", "Main3D", K.Bin, "3100"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "DisableDMACopy", K.Dword, "1"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "DisableBlockWrite", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "PP_ThermalAutoThrottlingEnable", K.Dword, "0"),
                new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Class\\{guid}\\0000", "DisableDrmdmaPowerGating", K.Dword, "1"),
                new(H.CU, "Software\\AMD\\CN", "AutoUpdateTriggered", K.Dword, "0"),
                new(H.CU, "Software\\AMD\\CN", "PowerSaverAutoEnable_CUR", K.Dword, "0"),
                new(H.CU, "Software\\AMD\\CN", "BuildType", K.Dword, "0"),
                new(H.CU, "Software\\AMD\\CN", "WizardProfile", K.Str, "PROFILE_CUSTOM"),
                new(H.CU, "Software\\AMD\\CN", "UserTypeWizardShown", K.Dword, "1"),
                new(H.CU, "Software\\AMD\\CN", "AutoUpdate", K.Dword, "0"),
                new(H.CU, "Software\\AMD\\CN", "RSXBrowserUnavailable", K.Str, "true"),
                new(H.CU, "Software\\AMD\\CN", "SystemTray", K.Str, "false"),
                new(H.CU, "Software\\AMD\\CN", "AllowWebContent", K.Str, "false"),
                new(H.CU, "Software\\AMD\\CN", "CN_Hide_Toast_Notification", K.Str, "true"),
                new(H.CU, "Software\\AMD\\CN", "AnimationEffect", K.Str, "false"),
                new(H.CU, "Software\\AMD\\CN\\OverlayNotification", "AlreadyNotified", K.Dword, "1"),
                new(H.CU, "Software\\AMD\\CN\\VirtualSuperResolution", "AlreadyNotified", K.Dword, "1"),
                new(H.CU, "Software\\AMD\\DVR", "PerformanceMonitorOpacityWA", K.Dword, "0"),
                new(H.CU, "Software\\AMD\\DVR", "DvrEnabled", K.Dword, "1"),
                new(H.CU, "Software\\AMD\\DVR", "ActiveSceneId", K.Str, "0"),
                new(H.CU, "Software\\AMD\\DVR", "PrevInstantReplayEnable", K.Dword, "0"),
                new(H.CU, "Software\\AMD\\DVR", "PrevInGameReplayEnabled", K.Dword, "0"),
                new(H.CU, "Software\\AMD\\DVR", "PrevInstantGifEnabled", K.Dword, "0"),
                new(H.CU, "Software\\AMD\\DVR", "RemoteServerStatus", K.Dword, "0"),
                new(H.CU, "Software\\AMD\\DVR", "ShowRSOverlay", K.Str, "false"),
                new(H.CU, "Software\\ATI\\ACE\\Settings\\ADL\\AppProfiles", "AplReloadCounter", K.Dword, "0"),
                new(H.LM, "Software\\AMD\\Install", "AUEP", K.Dword, "1"),
                new(H.LM, "Software\\AUEP", "RSX_AUEPStatus", K.Dword, "2"),
                new(H.LM, "System\\CurrentControlSet\\Services\\amdwddmg", "ChillEnabled", K.Dword, "0"),
            },
            new string[]
            {
            }),
    };

    static readonly Reg[] NetAdapterRegs =
    {
        new(H.LM, "", "AutoPowerSaveModeEnabled", K.Str, "0"),
        new(H.LM, "", "AutoDisableGigabit", K.Str, "0"),
        new(H.LM, "", "AdvancedEEE", K.Str, "0"),
        new(H.LM, "", "DisableDelayedPowerUp", K.Str, "2"),
        new(H.LM, "", "*EEE", K.Str, "0"),
        new(H.LM, "", "EEE", K.Str, "0"),
        new(H.LM, "", "EnablePME", K.Str, "0"),
        new(H.LM, "", "EEELinkAdvertisement", K.Str, "0"),
        new(H.LM, "", "EnableGreenEthernet", K.Str, "0"),
        new(H.LM, "", "EnableSavePowerNow", K.Str, "0"),
        new(H.LM, "", "EnablePowerManagement", K.Str, "0"),
        new(H.LM, "", "EnableDynamicPowerGating", K.Str, "0"),
        new(H.LM, "", "EnableConnectedPowerGating", K.Str, "0"),
        new(H.LM, "", "EnableWakeOnLan", K.Str, "0"),
        new(H.LM, "", "GigaLite", K.Str, "0"),
        new(H.LM, "", "NicAutoPowerSaver", K.Str, "2"),
        new(H.LM, "", "PowerDownPll", K.Str, "0"),
        new(H.LM, "", "PowerSavingMode", K.Str, "0"),
        new(H.LM, "", "ReduceSpeedOnPowerDown", K.Str, "0"),
        new(H.LM, "", "SmartPowerDownEnable", K.Str, "0"),
        new(H.LM, "", "S5NicKeepOverrideMacAddrV2", K.Str, "0"),
        new(H.LM, "", "S5WakeOnLan", K.Str, "0"),
        new(H.LM, "", "ULPMode", K.Str, "0"),
        new(H.LM, "", "WakeOnDisconnect", K.Str, "0"),
        new(H.LM, "", "*WakeOnMagicPacket", K.Str, "0"),
        new(H.LM, "", "*WakeOnPattern", K.Str, "0"),
        new(H.LM, "", "WakeOnLink", K.Str, "0"),
        new(H.LM, "", "WolShutdownLinkSpeed", K.Str, "2"),
    };

    static readonly Reg[] NetInterfaceRegs =
    {
        new(H.LM, "SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces", "TcpAckFrequency", K.Dword, "1"),
        new(H.LM, "SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces", "TCPNoDelay", K.Dword, "1"),
        new(H.LM, "SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces", "TcpDelAckTicks", K.Dword, "0"),
    };

    static readonly Reg[] NetGlobalRegs =
    {
        new(H.LM, "SYSTEM\\CurrentControlSet\\services\\LanmanServer\\Parameters", "SharingViolationDelay", K.Dword, "0"),
        new(H.LM, "SYSTEM\\CurrentControlSet\\services\\LanmanServer\\Parameters", "SharingViolationRetries", K.Dword, "0"),
    };

    static readonly string[] NetshCmds =
    {
        "netsh int tcp set global chimney=enabled",
        "netsh int tcp set global dca=enabled",
        "netsh int tcp set global netdma=disabled",
        "netsh int tcp set global congestionprovider=ctcp",
        "netsh int tcp set global ecncapability=disabled",
        "netsh int tcp set heuristics disabled",
        "netsh int tcp set global rss=enabled",
        "netsh int tcp set global fastopen=enabled",
        "netsh int tcp set global nonsackrttresiliency=disabled",
        "netsh int tcp set global rsc=enabled",
        "netsh int tcp set supplemental Internet congestionprovider=CUBIC",
        "netsh int tcp set global initialRto=1000",
        "netsh int tcp set global maxsynretransmissions=4",
    };

    static readonly Reg[] MouseRegs =
    {
        new(H.CU, "Control Panel\\Accessibility\\StickyKeys", "Flags", K.Str, "506"),
        new(H.CU, "Control Panel\\Accessibility\\Keyboard Response", "Flags", K.Str, "122"),
        new(H.CU, "Control Panel\\Accessibility\\ToggleKeys", "Flags", K.Str, "58"),
        new(H.LM, "SYSTEM\\CurrentControlSet\\Services\\USB", "DisableSelectiveSuspend", K.Dword, "1"),
        new(H.CU, "Control Panel\\Mouse", "MouseSpeed", K.Str, "0"),
        new(H.CU, "Control Panel\\Mouse", "MouseThreshold1", K.Str, "0"),
        new(H.CU, "Control Panel\\Mouse", "MouseThreshold2", K.Str, "0"),
        new(H.CU, "Control Panel\\Mouse", "MouseSensitivity", K.Str, "10"),
        new(H.CU, "Control Panel\\Keyboard", "KeyboardDelay", K.Str, "0"),
        new(H.CU, "Control Panel\\Keyboard", "KeyboardSpeed", K.Str, "31"),
        new(H.LM, "SYSTEM\\CurrentControlSet\\Services\\mouclass\\Parameters", "MouseDataQueueSize", K.Dword, "54"),
        new(H.LM, "SYSTEM\\CurrentControlSet\\Services\\kbdclass\\Parameters", "KeyboardDataQueueSize", K.Dword, "10"),
        new(H.LM, "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\kernel", "DebugPollInterval", K.Dword, "1000"),
        new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\csrss.exe\\PerfOptions", "CpuPriorityClass", K.Dword, "4"),
        new(H.LM, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\csrss.exe\\PerfOptions", "IoPriority", K.Dword, "3"),
        new(H.CU, "Control Panel\\Mouse", "SmoothMouseXCurve", K.Bin, "0000000000000000156e00000000000000400100000000029dc03000000000000002800000000000"),
        new(H.CU, "Control Panel\\Mouse", "SmoothMouseYCurve", K.Bin, "0000000000000000fd11010000000000002404000000000000fc12000000000000c0bb0100000000"),
    };

    // Параметры устройства: применяются к каждому USB-устройству в Enum\USB\*\*
    static readonly Reg[] MouseDeviceRegs =
    {
        new(H.LM, "Device Parameters\\Interrupt Management\\MessageSignaledInterruptProperties", "MSISupported", K.Dword, "1"),
        new(H.LM, "Device Parameters\\Interrupt Management\\Affinity Policy", "DevicePriority", K.Dword, "0"),
        new(H.LM, "Device Parameters", "EnhancedPowerManagementEnabled", K.Dword, "0"),
    };

    static readonly string[] ArtNvidiaProfile =
    {
        "",
        "                       =================================",
        "                       =================================",
        "                      ==================================",
        "               ========.........:=======================",
        "           =========   ======:......====================",
        "        ========     ============:....:=================",
        "      ======     ======.......=====:.....===============",
        "    ========   ===========:......=====:....:============",
        "    =====   ======     ====:....=====:....==============",
        "    =======  =====     =====::======....:===============",
        "     ======   =====    ===========....:======.:=========",
        "      =======  ======  ========:....-======......:======",
        "        ======   ======:===:.....=======:.........:=====",
        "         =======    ===....::========:.........:========",
        "            =======    ==========:.........:============",
        "              =========::::..........::=================",
        "                  =====......::=========================",
        "                       =================================",
        "                       =================================",
    };

    static readonly string[] ArtNvidiaGuid =
    {
        "",
        "    ▓▓▓",
        "     ▓▓▓",
        "      ▓▓",
        "      ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓    ███╗   ██╗██╗   ██╗██╗██████╗ ██╗ █████╗",
        "      ▓▓                              ▓▓    ████╗  ██║██║   ██║██║██╔══██╗██║██╔══██╗",
        "      ▓▓ ▓▓▓▓▓▓▓▓▓▓▓    ▓▓▓▓▓▓▓▓▓▓▓   ▓▓    ██╔██╗ ██║██║   ██║██║██║  ██║██║███████║",
        "      ▓▓               ▓▓▓ ▓▓  ▓▓▓▓▓█ ▓▓    ██║╚██╗██║╚██╗ ██╔╝██║██║  ██║██║██╔══██║",
        "      ▓▓ ▓▓▓▓▓▓▓▓▓▓▓  ▓▓▓▓ ▓▓▓▓▓▓  ▓▓ ▓▓    ██║ ╚████║ ╚████╔╝ ██║██████╔╝██║██║  ██║",
        "      ▓▓              ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ ▓▓    ╚═╝  ╚═══╝  ╚═══╝  ╚═╝╚═════╝ ╚═╝╚═╝  ╚═╝",
        "      ▓▓ ▓▓▓▓▓▓▓▓▓▓▓  ▓▓▓ ▓▓▓▓▓▓  ▓▓▓ ▓▓",
        "      ▓▓               ▓▓▓▓▓  ▓▓ ▓▓▓█ ▓▓",
        "      ▓▓ ▓▓▓▓▓▓▓▓▓▓▓    ▓▓▓▓▓▓▓▓▓▓▓   ▓▓",
        "      ▓▓                              ▓▓",
        "      ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓",
        "      ▓▓ ▓▓ ▓▓ ▓▓         ▓▓ ▓▓",
        "      ▓▓ ▓▓▓▓▓ ▓▓▓▓▓▓▓▓▓▓▓▓▓ ▓▓▓▓",
        "      ▓▓",
    };

    static readonly string[] ArtAmd =
    {
        "",
        "    ▓▓▓",
        "     ▓▓▓",
        "      ▓▓",
        "      ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓     █████╗ ███╗   ███╗██████╗",
        "      ▓▓                              ▓▓    ██╔══██╗████╗ ████║██╔══██╗",
        "      ▓▓ ▓▓▓▓▓▓▓▓▓▓▓    ▓▓▓▓▓▓▓▓▓▓▓   ▓▓    ███████║██╔████╔██║██║  ██║",
        "      ▓▓               ▓▓▓ ▓▓  ▓▓▓▓▓█ ▓▓    ██╔══██║██║╚██╔╝██║██║  ██║",
        "      ▓▓ ▓▓▓▓▓▓▓▓▓▓▓  ▓▓▓▓ ▓▓▓▓▓▓  ▓▓ ▓▓    ██║  ██║██║ ╚═╝ ██║██████╔╝",
        "      ▓▓              ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ ▓▓    ╚═╝  ╚═╝╚═╝     ╚═╝╚═════╝",
        "      ▓▓ ▓▓▓▓▓▓▓▓▓▓▓  ▓▓▓ ▓▓▓▓▓▓  ▓▓▓ ▓▓",
        "      ▓▓               ▓▓▓▓▓  ▓▓ ▓▓▓█ ▓▓",
        "      ▓▓ ▓▓▓▓▓▓▓▓▓▓▓    ▓▓▓▓▓▓▓▓▓▓▓   ▓▓",
        "      ▓▓                              ▓▓",
        "      ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓",
        "      ▓▓ ▓▓ ▓▓ ▓▓         ▓▓ ▓▓",
        "      ▓▓ ▓▓▓▓▓ ▓▓▓▓▓▓▓▓▓▓▓▓▓ ▓▓▓▓",
        "      ▓▓",
    };

    static readonly string[] ArtMouse =
    {
        "",
        "                                           , ,",
        "                                         ,','",
        "                                        ; ;",
        "                                        `.`.",
        "                                          ) ;",
        "                                     ,,,-','",
        "                      _____,,,,---''\",,,-'",
        "            ___,,--'\"\"_____,,,,--''\"\"",
        "    __,,--'\"__,,--'\"\"\"",
        " ,-\"_,,--'\"\"",
        "; ,'               .,------,....___",
        "; ;               /       ;        \"\"\"`---.._",
        "`.``-.._____,,,,,/       ;                   \"\"``.",
        "  ``--...___;;;;/-\"\"\"\"\"-;                         \\",
        "            ```;        ;                         ;;",
        "              ;        ;                         / ;",
        "             ;\"----....;___                     ; ;;",
        "             ;-,,,,,___    \"\"`\"--..._         ,' ; ;",
        "             ;         \"\"\"\"``---...__\"\"-...,-' ,'  ;",
        "             ;                       \"`-....,-'   /",
        "             `-._     _-------_                 ,'",
        "                 \"`--'\"\"\"\"\"\"\"\"\"``--..        ,,'",
        "                                     \"\"`---'\"",
    };

    static readonly string[] ArtPower =
    {
        "           ███        ██",
        "           ███        ██",
        "         █████       ██████",
        "        █████      ███████",
        "       ██████         ███",
        "     ███████████████  ██",
        "    ████ ███████████      █",
        "   ██████████  ███      ███",
        "  ███████████████      ████",
        "         ███████      ████████",
        "         █████       ████████",
        "         ████           ███",
        "        ████            ██",
        "       ███             ██",
    };

}
