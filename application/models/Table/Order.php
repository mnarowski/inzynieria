<?php

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of Order
 *
 * @author marcin
 */
class Application_Model_Table_Order extends Zend_Db_Table {
    
    protected $_name = 'Zamówienia';
    protected $_schema = 'dbo';
    protected $_rowClass = 'Model_Order';
}
