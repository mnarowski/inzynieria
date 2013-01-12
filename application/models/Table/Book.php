<?php

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of Book
 *
 * @author marcin
 */
class Application_Model_Table_Book extends Zend_Db_Table{
    
    protected $_name = 'Książki';
    protected $_schema = 'dbo';
    protected $_rowClass = 'Model_Book';
}
