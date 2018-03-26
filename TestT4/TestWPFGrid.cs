
<telerik:GridViewDataColumn Header="主键" DataMemberBinding="{Binding id,Mode=OneTime}"/>
<telerik:GridViewDataColumn Header="流程状态" DataMemberBinding="{Binding bpm_status,Mode=OneTime}"/>
<telerik:GridViewDataColumn Header="创建人名称" DataMemberBinding="{Binding create_name,Mode=OneTime}"/>
<telerik:GridViewDataColumn Header="创建人登录名称" DataMemberBinding="{Binding create_by,Mode=OneTime}"/>
<telerik:GridViewDataColumn Header="更新人名称" DataMemberBinding="{Binding update_name,Mode=OneTime}"/>
<telerik:GridViewDataColumn Header="更新人登录名称" DataMemberBinding="{Binding update_by,Mode=OneTime}"/>
<telerik:GridViewDataColumn Header="所属部门" DataMemberBinding="{Binding sys_org_code,Mode=OneTime}"/>
<telerik:GridViewDataColumn Header="所属公司" DataMemberBinding="{Binding sys_company_code,Mode=OneTime}"/>
<telerik:GridViewDataColumn Header="创建日期" DataMemberBinding="{Binding create_date,Mode=OneTime,StringFormat='{}{0:yyyy-MM-dd HH:mm:ss}'}"/>
<telerik:GridViewDataColumn Header="更新日期" DataMemberBinding="{Binding update_date,Mode=OneTime,StringFormat='{}{0:yyyy-MM-dd HH:mm:ss}'}"/>
<telerik:GridViewDataColumn Header="编号" DataMemberBinding="{Binding check_number,Mode=OneTime}"/>
<telerik:GridViewDataColumn Header="船名" DataMemberBinding="{Binding ship_name,Mode=OneTime}"/>
<telerik:GridViewDataColumn Header="营业运输证编号" DataMemberBinding="{Binding certificate_number,Mode=OneTime}"/>
<telerik:GridViewDataColumn Header="年审日期" DataMemberBinding="{Binding check_date,Mode=OneTime,StringFormat='{}{0:yyyy-MM-dd HH:mm:ss}'}"/>
<telerik:GridViewDataColumn Header="有效期至" DataMemberBinding="{Binding validity_to,Mode=OneTime,StringFormat='{}{0:yyyy-MM-dd HH:mm:ss}'}"/>
<telerik:GridViewDataColumn Header="年审结果" DataMemberBinding="{Binding check_result,Mode=OneTime}"/>
<telerik:GridViewDataColumn Header="审验机关" DataMemberBinding="{Binding check_organ,Mode=OneTime}"/>
<telerik:GridViewDataColumn Header="发证日期" DataMemberBinding="{Binding issure_date,Mode=OneTime,StringFormat='{}{0:yyyy-MM-dd HH:mm:ss}'}"/>
<telerik:GridViewDataColumn Header="年审说明" DataMemberBinding="{Binding check_explain,Mode=OneTime}"/>
<telerik:GridViewDataColumn Header="状态" DataMemberBinding="{Binding status,Mode=OneTime}"/>
<telerik:GridViewDataColumn Header="" DataMemberBinding="{Binding ship_id,Mode=OneTime}"/>
