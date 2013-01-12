<?php

class Bootstrap extends Zend_Application_Bootstrap_Bootstrap
{

    protected function _initConfig(){
        $config = new Zend_Config_Ini(APPLICATION_PATH.'/configs/application.ini');
        
        Zend_Registry::set('config', $config);
    }


    protected function _initResourceLoader() {
        $resourceLoader = new Zend_Loader_Autoloader_Resource(array(
                    'namespace' => '',
                    'basePath' => APPLICATION_PATH,
                ));
        $resourceLoader->addResourceType('model', 'models/','Model');
        $resourceLoader->addResourceType('form', 'forms/', 'Form');
        $resourceLoader->addResourceType('service', 'services/', 'Service');

        return $resourceLoader;
    }
    
    public function _initLayout(){
        Zend_Layout::startMvc();
    }
    
    public function _initDatabase(){
        $this->bootstrap('db');
    }
    
    public function _initCache(){
        
    }
    

}

