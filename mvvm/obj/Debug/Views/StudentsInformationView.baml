   M S B A M L   `   `   `  ����?  ;mvvm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:mvvm.ViewModelsmvvm.ViewModels  5      (    "mvvm.Views.StudentsInformationView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:mvvm.ViewModels     5        � DataContext  5
      )   #mvvm.ViewModels.StudentsInformation  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $��* �6   .+�5   
   R� -   5        $��StudentsTree��5   #   $��0��6   ��67   �� *Parent+��5      �� 5       �� ItemsSource 6+   ��  �� Path$ Children�.R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��0 0 5 0q�6?   ��6$   �� $
 Name�6?   5      5      5      �� 5!   
   -   5         ��Name$ tbFirst��5!      $��1��6#   $
��Left=�63   $��23��6N   $��	67,58,0,0q�6Z    �� TextWrapping$
 Wrap=�6m   $��TextBox��6�   $	��Top=�6�   $	��120��6�   �� 5"   
   -   5        $ tbSecond��5"      $��1��6$   $
��Left=�64   $��23��6O   $��	67,86,0,0q�6[   $
 Wrap=�6n   $��TextBox��6�   $	��Top=�6�   $	��120��6�   �� 5#   
   -   5        $
��Edit��5#      $��1��6    $
��Left=�60   $��
37,149,0,0q�6K   $	��Top=�6_   $��75��6w   6�   �� 5$   
   -   5        $��Create��5$      $��1��6"   $
��Left=�62   $��145,149,0,0q�6M   $	��Top=�6b   $��75��6z   6�   5%      5&      