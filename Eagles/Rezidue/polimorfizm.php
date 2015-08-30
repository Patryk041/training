<?php


	interface IWeAreEvolvingFast
	{
		public function LetsHaveFun($string, $int, $double, array $array);
		
		public function ThereIsEvenMoreFun($chunk, $array);
	}
	
	class Human
	{
		
	}
	
	class Issue
	{
		
	}
	
	class Animal
	{
		
	}
	
	class ChainOfResponsibilityPocSolidLReferenceType
	{
		/**
		 * @var Human
		 */
		public $Human;
		
		
		public $Issue;
		
		
		public $Animal;
	}