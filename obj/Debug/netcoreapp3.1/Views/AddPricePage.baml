   M S B A M L   `   `   `  ����B  >booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:booking.ViewModelsbooking.ViewModels  5   	        booking.Views.AddPricePage   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:booking.ViewModels     5   	     � Title$  	Add Price��5   	   $	��300��6   $	��300��6(    � DataContext 5	      *  $booking.ViewModels.AddPriceViewModel  5
   
   .��5      � .+�5   
   �� $
��Left=�6   $��	40,25,0,0q�6/   $��Camera:��6B   $
��Wrap=�6Q   $	��Top=�6e   �� 5   
   $
��Left=�6   $��
125,25,0,0q�6.   $	��Top=�6B   $	��150��6Z   ��6f   �� *Camere+ �� SelectedValue 6�   �� *SelectedCamera+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $
��Left=�6   $��	40,65,0,0q�6/   $��Data start:��6B   $
��Wrap=�6U   $	��Top=�6i   (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�6   $��
125,60,0,0q�60   $	��Top=�6D      SelectedDate 6\   �� *	StartDate+$ TwoWay=�$ PropertyChanged=��� 5   
   $
��Left=�6   $��
40,105,0,0q�6/   $��	Data end:��6C   $
��Wrap=�6T   $	��Top=�6h     5   
   $
��Left=�6   $��125,100,0,0q�60   $	��Top=�6E    6]   �� *	EndDate+$ TwoWay=�$ PropertyChanged=��� 5   
   $
��Left=�6   $��
40,145,0,0q�6/   $��Valoare:��6C   $
��Wrap=�6S   $	��Top=�6g   �� 5   
   $
��Left=�6   $��125,145,0,0q�6-    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��150��6�   ��6B   �� *
PriceValue+$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   -   5        $��Adauga pret��5      $��Center=�6'   $��	0,225,0,0q�6D   $	��Top=�6W   $	��100��6o   ��6{   ��  �� Path$ AddNewPrice�6�   5      5      