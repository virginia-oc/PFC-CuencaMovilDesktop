   M S B A M L   `   `   `  ����M  ICuencaMovilDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:CuencaMovilDesktop.UserControlsCuencaMovilDesktop.UserControls  5      9    3CuencaMovilDesktop.UserControls.UserControlClubForm   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:CuencaMovilDesktop.UserControls     5      .��5
      �� -   5          ��Name$  panel��5
      $��1��6!      panelFontStyle#��[  5      $��
60,0,60,20q�5      .+�5   
   ��   
titleLabel#��[ 6   $��0,0,0,10q�5      .��6&   Crear nueva asociación6>   �� 5   
     panelOverColor#��[ 6    �� CornerRadius$ 20��5       �� Padding$ 0,0,0,20q�5      ._�5      � -   5         �Name$
 form��5       � ColumnDefinitions 5      �� 5      6)   �� 5      6)   .+�5      �� $��0��6   $��30q�5   !   .+�5      ]� .+�5      ��   
fieldLabel#��[ 6    .��6D   
Nombre * :6P   �� 5      -   5         ��Name$ txtName��5   "     textBoxStyle1#��[ 5    !   .��6H   5!      5"      ]� 5$      .+�5%      �� #��[ 6    .��6D   Categoría * :6S   �� 5&      -   5        $ txtCategory��5&   "   #��[ 5'      .��6F   5(      5)      ]� 5+      .+�5,      �� #��[ 6    .��6D   Teléfono de contacto:6[   �� 5-      -   5        $ txtPhone��5-   "   #��[ 5.      .��6F   5/      50      ]� 52      .+�53      �� #��[ 6    .��6D   	Email * :6O   �� 54      -   5        $ txtEmail��54   "   #��[ 55      .��6F   56      57      ]� 59      .+�5:      �� #��[ 6    .��6D   
Sitio web:6P   �� 5;      -   5        $ 
txtWebsite��5;   "   #��[ 5<      .��6F   5=      5>      ]� 5@      .+�5A      �� #��[ 6    .��6D   Fotos adjuntas:6U   5B      �� 5D      $
��Auto=�6#   .��5E      ��  �� Orientation$ 
Horizontal=�6%   .+�5F      �� -   5         ��Name$ fotoEmp��5F   (   $	��130��69   $	��130��6F    
 color2#��[ 5G   %   $��2��5H   %   $��0,0,20,0q�5I   %   ��5J   "   �� 5K   &   -	   5        
imagenFoto�� �� ImageSource 5K   F   �� *Photo+5M      5N      5O      5P      �� 5R      $��1��6   $ Vertical=�5S      $��30q�5T      .+�5U      ]� .+�5V      �� #��[ 6    .��6D   Descripción*:6S   �� 5X      -
   5        $ tbDescription��5X   "     titleColor2#��[ 5Y   "   $��5,10,0,0q�5Z   "   $	��154��5[   "   	 �� TextWrapping$
	 Wrap=�5]   "   ��5\   "   �� *Notes+5]   8   5^      5_      5`      5b      �� 5d   
   -   5        
 ��Name$
 BtnSaveData��5d        	btnStyle1#��[ 5e      $��30, 10, 30, 0q�5f      $	��500��5g      $��Guardar datos��5h      6)   5i      5j      