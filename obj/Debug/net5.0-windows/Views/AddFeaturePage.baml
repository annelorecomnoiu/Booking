   M S B A M L   `   `   `  ����B  >booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:booking.ViewModelsbooking.ViewModels  5   	   "    booking.Views.AddFeaturePage   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:booking.ViewModels     5   	     � Title$  Add Feature��5   	   $	��200��6   $	��300��6*    � WindowStartupLocation$ CenterScreen=�66    � DataContext 5	      ,  &booking.ViewModels.AddFeatureViewModel  5
   
   .��5      � 
�����@�.+�5   
   �� $
��Left=�6   $��	20,50,0,0q�6/   $��Nume dotare:��6B   $
��Wrap=�6V   $	��Top=�6j   �� 5   
   $
��Left=�6   $��
120,50,0,0q�6-    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��150��6�   ��6A   �� *FeatureName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $��Adauga dotare��5      $
��Left=�6)   $��120,123,0,0q�6D   $	��Top=�6Y   $	��150��6q   
���������6}   �� *AddNewFeature+6�   5      5      