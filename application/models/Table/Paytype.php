<?php

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of Paytype
 *
 * @author marcin
 */
class Application_Model_Table_Paytype extends Zend_DB_Table {
    
    protected $_name = 'Formy_Płatności';
    protected $_schema = 'dbo';
    protected $_rowClass = 'Model_Paytype';
}
