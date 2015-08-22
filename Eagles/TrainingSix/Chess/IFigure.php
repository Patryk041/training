<?php

	interface IFIgure
	{
		function Move($coordinates);
		
		function GetColour();
		
		function GetShape();// url obrazka, base 64 obrazka itp
	}