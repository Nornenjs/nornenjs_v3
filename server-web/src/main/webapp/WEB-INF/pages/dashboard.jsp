<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<%@ include file="../layout/header.jspf" %>
<%@ include file="../layout/nav.jspf" %>


<section class="layoutContentSectionWrap">

    <section class="layoutContentSection">

        <header>
            <h2>Dash Board</h2>
        </header>
        
        <sec:authorize access="hasRole('ROLE_DOCTOR')">
        
        </sec:authorize>
        
        <sec:authorize access="isAnonymous()">
        
        </sec:authorize>

        <button id="redisConfirm">RedisConfrim</button>

        <script>

            $(function(){
               $('#redisConfirm').on('click', function(){
                   $.getJSON(contextPath+'/volume/publisher', function(result){
                      alert(result)
                   });
               });
            });

        </script>

    </section>

</section>

<%@ include file="../layout/footer.jspf" %>