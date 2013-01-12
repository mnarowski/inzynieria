$(function(){
    
    $.fn.jsonForm = function(){
        var self = this;
        var data;
        self.children("input,textarea,select").each(function(){
            var _attr = $(this).attr('id');
            $.extend(data,{
                _attr : $(this).val()
            });
        });
        
        return data;
    }
    
})(jQuery)

