<?php

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of Promotion
 *
 * @author marcin
 */
class Application_Model_Table_Promotion extends Zend_Db_Table {
    
    
    protected $_name = 'Promocje';
    protected $_schema = 'dbo';
    protected $_rowClass = 'Model_Promotion';
}
