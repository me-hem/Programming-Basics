<?php

	echo "String Functions";
	
	$str = "Hello";
	echo "<br>Length: ".strlen($str);
	
	$str = "Hello World!";
	echo "<br>Word Count: ".str_word_count($str);
	
	echo "<br>Reversed String: ".strrev($str);
	
	echo "<br>Position: ".strpos($str,"World");
	
	echo "<br>Replaced String: ".str_replace("World", "India", $str);
?>