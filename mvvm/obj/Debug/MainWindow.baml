   M S B A M L   `   `   `  ����?  ;mvvm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:mvvm.ViewModelsmvvm.ViewModels  5   	       mvvm.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   /localclr-namespace:mvvm.ViewModels     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��600��6)    � DataContext 5      #  mvvm.ViewModels.MainViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   o� $
��Left=�6   $��42��6*   $��0��66   $	��Top=�6C   $	��500��6[   .@�5      �� $��32��6   $	��135��6!   $��Students Information��6-   ��6L   �� * StudentsInformationViewCommand+5      �� 5   
   -   5        $��ContentView��5   M   $��1��6   ��6&   �� *CurrentUserControl+6M   5      5      