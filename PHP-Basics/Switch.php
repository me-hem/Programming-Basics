<?php

	echo "<br> Switch Case";
	$chr = 'e';
	
	switch($chr)
	{
		case 'a':
		case 'e':
		case 'i':
		case 'o':
		case 'u':
			echo "<br>$chr is a vovel.";
			break;
		default:
			echo "<br>$chr is not a vovel.";
	}
?>