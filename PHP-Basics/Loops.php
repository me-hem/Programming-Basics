<?php

	echo "Loops";
	
	echo "<br><br>For Loop";
	for($i=0; $i<10; ++$i)
		echo "<br>i => $i";
	
	echo "<br><br>For Each Loop";
	$cars = array("Car1", "Car2", "Car3");
	foreach($cars as $item)
		echo "<br>Car => $item";
		
	echo "<br><br>While Loop";
	$num = 5;
	while($num > 0)
	{
		echo "<br>Just Chill => $num";
		$num--;
	}
	
	echo "<br><br>Do While Loop";
	$num = 5;
	do
	{
		echo "<br>Just Chill => $num";
		$num--;
	}while($num > 0);
	
?>