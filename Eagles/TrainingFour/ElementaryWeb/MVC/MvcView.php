<?php

	abstract class MvcView
	{
		protected function RenderErrors(MvcModel $model)
		{
			//foreach ($model->ErrorsList)
		//	{
				
			//}
			
			
		}
		
		public function Render(MvcModel $model)
		{
			if (sizeof($model->ErrorsList) > 0)
			{
				$errorHtml = $this->RenderErrors($model);
			}
			
			$this->GenerateOutput($model);
		}
		
		protected abstract function GenerateOutput(MvcModel $model);
	}