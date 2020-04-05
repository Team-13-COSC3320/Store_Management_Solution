--------------------------------------------Create REVIEW Master Procedure-------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------------------------------------
Create Procedure ReviewMasterInsertUpdateDelete (@R_ID INTEGER,
										  @R_UID INTEGER,
										  @R_TITLE CHAR(50),
										  @R_CONTENT CHAR(300),
										  @R_STAR INTEGER,
										  @StatementType NVarChar(20) = '')
AS 
	BEGIN
		IF @StatementType = 'Insert'
			Begin 
				Insert into dbo.REVIEW
								(R_UID,
								R_Title,
								R_Content,
								R_Star)
				Values			(@R_UID,
								@R_Title,
								@R_Content,
								@R_Star)
				End
		If @StatementType = 'Select'
			Begin
				Select *
				From dbo.REVIEW
			End

		If @StatementType = 'Update'
			Begin
				Update dbo.REVIEW
				Set R_Title = @R_TITLE,
					R_Content = @R_CONTENT,
					R_Star = @R_STAR
				Where R_ID = @R_ID AND R_UID = @R_UID
			End

		Else If @StatementType = 'Delete'
			Begin
				Delete From dbo.REVIEW
				Where R_UID = @R_UID
				And R_ID = @R_ID 
			End
	End

---------------------------------------------------------------------------------------------------------------------------------------------------------------------