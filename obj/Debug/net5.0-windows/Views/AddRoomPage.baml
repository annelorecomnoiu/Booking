   M S B A M L   `   `   `  ����B  >booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:booking.ViewModelsbooking.ViewModels  5   	       booking.Views.AddRoomPage   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:booking.ViewModels     5   	     � Title$  Add Room��5   	   $	��550��6   $	��300��6'    � WindowStartupLocation$ CenterScreen=�63    � DataContext 5	      )  #booking.ViewModels.AddRoomViewModel  5
   
   .��5      � 
�����@�.+�5   
   �� $
��Left=�6   $��	40,25,0,0q�6/   $��Nume camera:��6B   $
��Wrap=�6V   $	��Top=�6j   �� 5   
   $
��Left=�6   $��
125,25,0,0q�6-    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��150��6�   ��6A   �� *
RoomName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��	40,65,0,0q�6/   $��
Nr camere:��6B   $
��Wrap=�6T   $	��Top=�6h   �� 5   
   -   5        $��NumarCamere��5      $
��Left=�6%   $��
125,65,0,0q�6@   $
 Wrap=�6�   $	��Top=�6�   $	��150��6�   ��6T   �� *	NoOfRooms+$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
40,105,0,0q�6/   $��Capacitate:��6C   $
��Wrap=�6V   $	��Top=�6j   �� 5   
   $
��Left=�6   $��125,105,0,0q�6.   $	��Top=�6C   $	��150��6[    �� SelectedValue 6g   �� *RoomCapacity+$ TwoWay=�$ PropertyChanged=�.@�5      �� $��1��6   �� 5      $��2��6   �� 5      $��3��6   �� 5      $��4��6   �� 5      $��5��6   5      �� 5   
   $
��Left=�6   $��
40,145,0,0q�6/   $��Imagini camera:��6C   $
��Wrap=�6Z   $	��Top=�6n   �� 5   
   $��Adauga imagini��6   $
��Left=�6*   $��135,145,0,0q�6E   $	��Top=�6Z   $	��100��6r   
���������6~   ��  �� Path$ AddImage�6�   �� 5   
   $
��Left=�6   $	��100��6+   $��100,175,0,0q�68   $	��Top=�6M   $	��100��6e   ��6q   �� *CurrentImage+$ TwoWay=�$ PropertyChanged=��� 5   
   $��Previous image��6   $
��Left=�6*   $��
40,285,0,0q�6E   $	��Top=�6Y   $	��100��6q   
���������6}   �� $ PreviousImage�6�   �� 5   
   $��
Next image��6   $��Right=�6&   $��
0,285,40,0q�6B   $	��Top=�6V   $	��100��6n   
���������6z   �� $ 	NextImage�6�   �� 5    
   $
��Left=�6   $��
40,325,0,0q�6/   $��Dotari camera:��6C   $
��Wrap=�6Y   $	��Top=�6m   �� 5!   
   $
��Left=�6   $��125,325,0,0q�6.   $	��Top=�6C   $	��150��6[   ��6g   �� *DotariCamera+$ TwoWay=�$ PropertyChanged=� �� SelectedItem 6�   �� *CurrentNewFeature+$ TwoWay=�$ PropertyChanged=��� 5"   
   $��Adauga dotare��6   $
��Left=�6)   $��150,352,0,0q�6D   $	��Top=�6Y   $	��100��6q   
���������6}   �� $ 
AddFeature�6�   �� 5$   
   $
��Left=�6   $��
40,400,0,0q�6/   $��Dotari selectate:��6C   $
��Wrap=�6\   $	��Top=�6p   �� 5%   
   $
��Left=�6   $��130,400,0,0q�6.   $	��Top=�6C   $	��150��6[   ��6g   �� *DotariAdaugate+$ TwoWay=�$ PropertyChanged=� 6�   �� *CurrentAddedFeature+$ TwoWay=�$ PropertyChanged=��� 5&   
   $��Sterge dotare��6   $
��Left=�6)   $��150,450,0,0q�6D   $	��Top=�6Y   $	��100��6q   
���������6}   �� $ RemoveFeature�6�   �� 5(   
   $��Adauga camera��6   $
��Left=�6)   $��150,488,0,0q�6D   $	��Top=�6Y   $	��100��6q   
���������6}   �� $ AddRoom�6�   5*      5+      