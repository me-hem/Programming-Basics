<?php

	echo "Integer Functions";
	$var1 = 5;
	$var2 = 5.9;
	$var3 = acos(8);
	$var4 = 5.67652323;
	echo "<br>$var1 is int: ".is_int($var1);
	echo "<br>$var2 is int: ".is_int($var2);
	echo "<br>$var1 is numeric: ".is_numeric($var1);
	echo "<br>$var3 data type: ".var_dump($var3);
	echo "<br>$var4 round-off: ".round($var4);
	
?>