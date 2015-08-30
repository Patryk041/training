<?php

	abstract class RegularChorHandler //extends AlsmostChor
	{
		public function ThisIsTotalllyIrrelevantOnlyForPrsentationPurposes() // !!!
		{
			//$this->
		}
		
		public abstract function Handle(ChainOfResponsibilityPocSolidLReferenceType $refEnity);
	}
	
	class AnimalChorHandler extends RegularChorHandler
	{
		public function Handle(ChainOfResponsibilityPocSolidLReferenceType $refEnity)
		{
			$refEnity->Animal = 3;
		}
	}
	
	class HumanChorHandler extends RegularChorHandler
	{
		
	}
	
	class ChainOfResponsibilityManager extends AlsmostChor
	{
		public function ThisIsTotalllyIrrelevantOnlyForPrsentationPurposes() // !!!
		{
			//$this->
		}
	}