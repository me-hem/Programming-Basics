<?php

	echo "Jump Statements";
	
	echo "<br><br>Continue";
	for($i=0; $i<5; ++$i)
	{
		if($i == 3)
			{
				echo "<br>Continuing at i = $i";
				continue;
			}
		echo "<br>i => $i";			
	}
	
	echo "<br><br>Break";
	for($i=0; $i<5; ++$i)
	{
		if($i == 3)
			{
				echo "<br>Breaking at i = $i";
				break;
			}
		echo "<br>i => $i";			
	}
	
	echo "<br><br>Go To";
	$flag = 0;
	start:
	if($flag % 2 != 0)
		echo "<br>Program Khatam.";
	else
	{
		$flag++;
		goto start;
	}
	
?>