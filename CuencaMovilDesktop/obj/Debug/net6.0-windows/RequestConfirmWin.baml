   M S B A M L   `   `   `  ����M  ICuencaMovilDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CuencaMovilDesktopCuencaMovilDesktop  5   	   *    $CuencaMovilDesktop.RequestConfirmWin   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:CuencaMovilDesktop     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	     � Title$  Mensaje info��5	   	   $	��200��6   $	��350��6+    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency$
 True��5   	      winStyle#��[  5   	   .��5      ��  �� CornerRadius$ 10��6   $��1q�5       J� Opacity$
 0.95Q�5      ��5   
   �� 5       �� 
StartPoint$	 1,1&�6"    �� EndPoint$	 0,0&�63   .��5      �   primaryBackColor1	 � Color#	 [ 6   
 � Offset$
 0Q�6J   � 5        primaryBackColor2#	 [ 6   $
 1Q�6J   5      ��5   
   �� 5      $	 0,0&�6"   $	 1,1&�63   .��5      �   winBorderColor1#	 [ 6   $
 0Q�6H   � 5        winBorderColor2#	 [ 6   $	
 0.5Q�6H   � 5        winBorderColor3#	 [ 6   $
 1Q�6H   5      ._�5!   
   �  � RowDefinitions 5"      �� 5#      $��25 �6    �� 5$      $��* �6    .+�5'      �� -   5         ��Name$ pnlControlBar��5'      $��0��5(       �� Orientation$ 
Horizontal=�5)      $��RightToLeft=�5*      
������ $��0,0,5,0q�5,      .+�50      �� -   5         ��Name$ BtnClose��50        controlButton#��[ 51       
 color4
 � Tag# [ 52      .��54      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Xmark=�6#     controlButtonIcon#��[ 60   55      56      �� 58      $��1��6   .+�59      �� -   5         ��Name$ 
lblMessage��59       	 
titleLabel#��[	 5:      $��0,30,0,0q�5;      $��16(�5<      $��Contenido aquí��5=      ]� 5?      $��20, 20, 20, 0q�6   .+�5@      �� -   5        $ 
BtnAceptar��5@       
 	btnStyle1#��[
 5A      $��20q�5B      $��Aceptar��5C      $	��100��5D      5E      �� 5F      -   5        $ BtnCancelar��5F      #��[
 5G      $��20q�5H      $��Cancelar��5I      $	��100��5J      6)   5L      5M      5N      5O      5P      