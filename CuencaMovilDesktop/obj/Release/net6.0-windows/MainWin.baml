   M S B A M L   `   `   `  ����   CuencaMovilDesktop     CuencaMovilDesktop.MainWin   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  -     � Title$  Menu Principal��$	��900��$
��1280�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ Manual=� � WindowStyle$
 None=�
������  � AllowsTransparency$
 True��   winStyle#��[  .���  � RowDefinitions �� $	��120 ��� .+���  �� CornerRadius$ 	10,10,0,0��$��1������  �� 
StartPoint$	 1,1&� �� EndPoint$	 0,0&�.���   primaryBackColor1	 � Color#	 [ 
 � Offset$
 0Q��   primaryBackColor2#	 [ $
 1Q�� $��0�� �� $��40 ��� $��* �.+��� -    ��Name$ pnlControlBar��$��0�� �� Orientation$ 
Horizontal=�$��RightToLeft=�
������ $��0,0,5,0q�.+��� -    ��Name$ btnClose��  controlButton#��[  
 color4
 � Tag# [ .��!  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Xmark=�  controlButtonIcon#��[ � $��1�� � ColumnDefinitions �� �� .+��� $��0��$ 
Horizontal=�$��LeftToRight=�$��Center=�  panelFontStyle#��[ .+��� $��Cuenca Móvil��  titleColor2#��[ $��26(�$��Medium"�$��Center=�$��60,0,0,0q��� $��1��$ 
Horizontal=�$��RightToLeft=�$��Center=�$��0,0,20,0q�.+��� $��Center=�$��0,0,30,0q�#��[ �� -    ��Name$ nombreUsuario��$��Usuario��  titleColor3#��[ $��
Montserrat)�$��16(�$��Center=�$��SemiBold"�A� -    A�Name$ fotoUsuario��$��50��$��50�� 
	 color2#��[	 $��2��$��	10,0,10,0q�����  �� ImageSource �� *Photo+�� #��["�$��30��$��1��$��	10,0,10,0q���  
 
iconButton#��[
  
 color3# [ .��  $
 Bell=�  iconButtonIcon#��[ � $��1��.+��� $ 	0,0,10,10��$��0,0,0,0q�$��Center=�$
��1280������ $	 1,1&�$	 0,0&�.��� #	 [ $
 0Q�� #	 [ $
 1Q�� -    �Name$ panel��$��100, 10, 20, 20q��� -    ��Name$ 	bordeMenu��$ 0,0,0,10��$
��Left=�$��90��  bordeDesplegable#��[ ���� $	 0,0&�$ 1,0.7&�.���   secondaryBackColor1#	 [ $
 0Q��   secondaryBackColor2#	 [ $
 1Q�._��� $	��300��$
��Left=�$��0,20,0,0q�.+�	� -    	�Name$
 home��  
menuButton#��[   color10# [ ���� *ShowHomeViewCommand+.���� $ 
Horizontal=�.+�  $
 Home=�  menuButtonIcon#��[ �� $��5,0,0,0q�$��Inicio��  menuButtonText#��[ 	� -	   $ showReports��#��[ # [	 ���� *ShowCustomerViewCommand+.���� $ 
Horizontal=�.+�  $ 
FolderOpen=�#��[ �� $��5,0,0,0q�$��Consultar reportes��#��[ 	� -
   $ 
editReport��#��[  
 color1# [ ���� *ShowHomeViewCommand+.���� $ 
Horizontal=�.+�  $ FilePen=�#��[ �� $��5,0,0,0q�$��Modificar reporte��#��[ 	� -   $ printReport��#��[ # [ ���� *ShowCustomerViewCommand+.���� $ 
Horizontal=�.+�  $ Print=�#��[ �� $��5,0,0,0q�$��Imprimir reporte��#��[ 	� -   $ 	showClubs��#��[ # [ ���� *ShowHomeViewCommand+.���� $ 
Horizontal=�.+�  $ PeopleGroup=�#��[ �� $��5,0,0,0q�$��Consultar asociaciones��#��[ 	� -   $ addClub��#��[  
 color9# [ ���� *ShowCustomerViewCommand+.���� $ 
Horizontal=�.+�  $ UserPlus=�#��[ �� $��5,0,0,0q�$��Añadir asociación��#��[ 	� -   $ editClub��#��[  
 color6# [ ���� *ShowCustomerViewCommand+.���� $ 
Horizontal=�.+�  $ UserPen=�#��[ �� $��5,0,0,0q�$��Editar asociación��#��[ 	� -   $ newBroadcast��#��[  
 color5# [ ���� *ShowCustomerViewCommand+.���� $ 
Horizontal=�.+�  $ Bullhorn=�#��[ �� $��5,0,0,0q�$��Nueva difusión��#��[ 