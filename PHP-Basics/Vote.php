<?php

	$nation = $_POST["country"];
	$age = $_POST["age"];
	
	if($nation == "India")
		if($age > 17)
			echo "<br>Country: India <br>Age: $age <br>Message: You are eligible to vote!";
		else
			echo "<br>Country: India <br>Age: $age <br>Message: You are not eligible to vote!";
	else
		echo "<br>Country: $nation <br>Age: $age <br>Message: This program is only for Indians, try our another program.";
?>