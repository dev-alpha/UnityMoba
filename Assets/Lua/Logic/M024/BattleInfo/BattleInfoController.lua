require "System.Global"

class("BattleInfoController")

local Data = UTGData.Instance()
local Text = "UnityEngine.UI.Text"
local Image = "UnityEngine.UI.Image"
local Slider = "UnityEngine.UI.Slider"
local RectTrans = "RectTransform"


function BattleInfoController:Awake(this)
  self.this = this
  self.leftTab = self.this.transforms[0]
  self.blue = self.this.transforms[1]
  self.red = self.this.transforms[2]

  self.kdaBluePanel = {}
  self.kdaRedPanel = {}
  self.propertyBluePanel = {}
  self.propertyRedPanel = {}
  self.baseBlueInfo = {}
  self.baseRedInfo = {}
  self.blueEquips = {{},{},{},{},{}}
  self.redEquips = {{},{},{},{},{}}

  for i = 1,self.blue.childCount do
  	table.insert(self.kdaBluePanel,self.blue:GetChild(i - 1):Find("PlayerInfo/Panel"))
  	table.insert(self.propertyBluePanel,self.blue:GetChild(i - 1):Find("PlayerInfo/Property"))
  	table.insert(self.baseBlueInfo,self.blue:GetChild(i - 1):Find("PlayerInfo"))
  end

  for i = 1,self.red.childCount do
  	table.insert(self.kdaRedPanel,self.red:GetChild(i - 1):Find("PlayerInfo/Panel"))
  	table.insert(self.propertyRedPanel,self.red:GetChild(i - 1):Find("PlayerInfo/Property"))
  	table.insert(self.baseRedInfo,self.red:GetChild(i - 1):Find("PlayerInfo"))
  end

  self.blueHeroLevel = {}
  self.blueHeroDeadCount = {}
  self.blueCDCount = {}
  self.blueKillNum = {}
  self.blueDeadNum = {}
  self.blueAsNum = {}
  self.blueMoneyNum = {}
  self.blueHp = {}
  self.bluePAtk = {}
  self.blueMAtk = {}
  self.bluePDef = {}
  self.blueMDef = {}

  self.redHeroLevel = {}
  self.redHeroDeadCount = {}
  self.redCDCount = {}
  self.redKillNum = {}
  self.redDeadNum = {}
  self.redAsNum = {}
  self.redMoneyNum = {}
  self.redHp = {}
  self.redPAtk = {}
  self.redMAtk = {}
  self.redPDef = {}
  self.redMDef = {}

  for i = 1,5 do
  	for k = 1,6 do
  		self.blueEquips[i][k] = self.blue:GetChild(i-1):Find("PlayerInfo/Panel/Panel/Equip" .. k)
  		self.redEquips[i][k] = self.red:GetChild(i-1):Find("PlayerInfo/Panel/Panel/Equip" .. k) 		
  	end
  	self.blueHeroLevel[i] = self.blue:GetChild(i-1):Find("PlayerInfo/IconMask/Icon/Level")
  	self.redHeroLevel[i] = self.red:GetChild(i-1):Find("PlayerInfo/IconMask/Icon/Level")

  	self.blueHeroDeadCount[i] = self.blue:GetChild(i-1):Find("PlayerInfo/IconMask/Icon/DeadCountDown")
	self.redHeroDeadCount[i] = self.red:GetChild(i-1):Find("PlayerInfo/IconMask/Icon/DeadCountDown")

	self.blueCDCount[i] = self.blue:GetChild(i-1):Find("PlayerInfo/Panel/Image/Text")
	self.redCDCount[i] = self.red:GetChild(i-1):Find("PlayerInfo/Panel/Image/Text")

	self.blueKillNum[i] = self.blue:GetChild(i-1):Find("PlayerInfo/Panel/Kill")
	self.redKillNum[i] = self.red:GetChild(i-1):Find("PlayerInfo/Panel/Kill")		

	self.blueDeadNum[i] = self.blue:GetChild(i-1):Find("PlayerInfo/Panel/Dead")
	self.redDeadNum[i] = self.red:GetChild(i-1):Find("PlayerInfo/Panel/Dead")

	self.blueAsNum[i] = self.blue:GetChild(i-1):Find("PlayerInfo/Panel/Assistant")
	self.redAsNum[i] = self.red:GetChild(i-1):Find("PlayerInfo/Panel/Assistant")

	self.blueMoneyNum[i] = self.blue:GetChild(i-1):Find("PlayerInfo/Panel/Money")
	self.redMoneyNum[i] = self.red:GetChild(i-1):Find("PlayerInfo/Panel/Money")

	self.blueHp[i] = self.blue:GetChild(i-1):Find("PlayerInfo/Property/Hp")
	self.redHp[i] = self.red:GetChild(i-1):Find("PlayerInfo/Property/Hp")

	self.bluePAtk[i] = self.blue:GetChild(i-1):Find("PlayerInfo/Property/PAtk")	
	self.redPAtk[i] = self.red:GetChild(i-1):Find("PlayerInfo/Property/PAtk")

	self.blueMAtk[i] = self.blue:GetChild(i-1):Find("PlayerInfo/Property/MAtk")
	self.redMAtk[i] = self.red:GetChild(i-1):Find("PlayerInfo/Property/MAtk")

	self.bluePDef[i] = self.blue:GetChild(i-1):Find("PlayerInfo/Property/PDef")
	self.redPDef[i] = self.red:GetChild(i-1):Find("PlayerInfo/Property/PDef")

	self.blueMDef[i] = self.blue:GetChild(i-1):Find("PlayerInfo/Property/MDef")
	self.redMDef[i] = self.red:GetChild(i-1):Find("PlayerInfo/Property/MDef")		


  end
  self.cancelButton = self.this.transform:Find("MainFrame/CancelButton")
  self.sortButton = self.this.transform:Find("MainFrame/SortButton")
  self.isReceiveData = false
  self.isSorting = false
  self.data = {}
  self.firstTime = 0
  self.firstTimeOrder1 = {}
  self.firstTimeOrder2 = {}
  self.playerNum = 0

  --??????????????????
  local listener = NTGEventTriggerProxy.Get(self.leftTab:Find("BaseOption").gameObject)
  local callback1 = function(self, e)
    self:TabControl(1)
  end
  listener.onPointerClick = NTGEventTriggerProxy.PointerEventDelegateSelf(callback1, self)

  listener = NTGEventTriggerProxy.Get(self.leftTab:Find("ControlOption").gameObject)
  local callback2 = function(self, e)
    self:TabControl(2)
  end
  listener.onPointerClick = NTGEventTriggerProxy.PointerEventDelegateSelf(callback2, self)

  listener = NTGEventTriggerProxy.Get(self.cancelButton.gameObject)
  local callback2 = function(self, e)
    self.isReceiveData = false
    self.this.transform.parent.localPosition = Vector3.New(-1290,0,0)
    self.this.transform.parent.gameObject:SetActive(false)
 	if self.closeDelegate ~= nil then
		self.this:InvokeDelegate(self.closeDelegate)
	end
  end
  listener.onPointerClick = NTGEventTriggerProxy.PointerEventDelegateSelf(callback2, self)

  listener = NTGEventTriggerProxy.Get(self.sortButton.gameObject)
  local callback3 = function(self, e)
    self:SortControl()
  end
  listener.onPointerClick = NTGEventTriggerProxy.PointerEventDelegateSelf(callback3, self)


end

function BattleInfoController:Start()


	self.this.transform.parent.localPosition = Vector3.New(-1290,0,0)
	if self.closeDelegate ~= nil then
		self.this:InvokeDelegate(self.closeDelegate)
	end
	self.isReceiveData = false
end

function BattleInfoController:TabControl(num)
	if num == 1 then
		self.leftTab:Find("BaseOption/Selected1").gameObject:SetActive(true)
		self.leftTab:Find("ControlOption/Selected2").gameObject:SetActive(false)
		self.leftTab.parent:Find("Panel/Panel").gameObject:SetActive(true)
		self.leftTab.parent:Find("Panel/PropertyTitle").gameObject:SetActive(false)
		for i = 1,5 do
			self.kdaBluePanel[i].gameObject:SetActive(true)
			self.kdaRedPanel[i].gameObject:SetActive(true)
			self.propertyBluePanel[i].gameObject:SetActive(false)
			self.propertyRedPanel[i].gameObject:SetActive(false)
		end
	elseif num == 2 then
		self.leftTab:Find("BaseOption/Selected1").gameObject:SetActive(false)
		self.leftTab:Find("ControlOption/Selected2").gameObject:SetActive(true)
		self.leftTab.parent:Find("Panel/Panel").gameObject:SetActive(false)
		self.leftTab.parent:Find("Panel/PropertyTitle").gameObject:SetActive(true)
		for i = 1,5 do
			self.kdaBluePanel[i].gameObject:SetActive(false)
			self.kdaRedPanel[i].gameObject:SetActive(false)
			self.propertyBluePanel[i].gameObject:SetActive(true)
			self.propertyRedPanel[i].gameObject:SetActive(true)
		end
	end

end

function BattleInfoController:SortControl()
	-- body
	if self.isSorting == false then
		self.isSorting = true
		self.sortButton:Find("Text"):GetComponent(Text).text = "??????????????????"
		
	elseif self.isSorting == true then
		self.isSorting = false
		self.sortButton:Find("Text"):GetComponent(Text).text = "???????????????"
		self:InitSelfInfo(self.firstTimeOrder1,self.selfNum)
		self:InitEnemyInfo(self.firstTimeOrder2,self.enemyNum)
	end
end

function BattleInfoController:ShowInfoControl(selfNum,enemyNum)
	-- body
	for i = 1,5 do
		if i > selfNum then
			self.blue:GetChild(i - 1).gameObject:SetActive(false)
		end
	end

	for i = 1,5 do
		if i > enemyNum then
			self.red:GetChild(i - 1).gameObject:SetActive(false)
		end
	end
end

function BattleInfoController:CurrentData(dataSelf,dataEnemy)

	-- body

		if self.firstTime == 0 then
			self.firstTime = 1
			self.firstTimeOrder1 = dataSelf
			self.firstTimeOrder2 = dataEnemy
			self.selfNum = dataSelf.Length
			self.enemyNum = dataEnemy.Length
			self:ShowInfoControl(self.selfNum,self.enemyNum)
			self:InitSelfInfo(self.firstTimeOrder1,self.selfNum)
			self:InitEnemyInfo(self.firstTimeOrder2,self.enemyNum)
			self:UpdateSelfInfo(dataSelf,self.selfNum)
			self:UpdateEnemyInfo(dataEnemy,self.enemyNum)
			if self.closeDelegate ~= nil then
				
				self.this:InvokeDelegate(self.closeDelegate)
			end
			--print("?????????self.closeDelegate")
		end
	if self.isReceiveData == true then
		if self.isSorting == false then
			self:UpdateSelfInfo(dataSelf,self.selfNum)
			self:UpdateEnemyInfo(dataEnemy,self.enemyNum)
		elseif self.isSorting == true then
			local temp = ""
			if dataSelf.Length > 1 then
				for i = 0,dataSelf.Length-1 do
					temp = ""
					if i < dataSelf.Length-2 then
						if dataSelf[i].Money > dataSelf[i+1].Money then
							temp = dataSelf[i+1]
							dataSelf[i+1] = dataSelf[i]
							dataSelf[i] = temp
						end
					end
				end 
			end
			if dataEnemy.Length > 1 then
				for i = 0,dataEnemy.Length-1 do
					temp = ""
					if i < dataEnemy.Length-2 then				
						if dataEnemy[i].Money > dataEnemy[i+1].Money then
							temp = dataSelf[i+1]
							dataEnemy[i+1] = dataEnemy[i]
							dataEnemy[i] = temp
						end
					end
				end 
			end
			self:InitSelfInfo(dataSelf,self.selfNum)
			self:InitEnemyInfo(dataEnemy,self.enemyNum)
			self:UpdateSelfInfo(dataSelf,self.selfNum)
			self:UpdateEnemyInfo(dataEnemy,self.enemyNum)
		end
	end
end

function BattleInfoController:InitSelfInfo(dataSelf,selfNum)
  --??????Icon
  if selfNum ~= 0 then
  for i = 1,selfNum do

  		self.baseBlueInfo[i].parent:Find("Image").gameObject:SetActive(false)

	  	self.baseBlueInfo[i]:Find("IconMask/Icon"):GetComponent(Image).sprite = UITools.GetSprite("roleicon",dataSelf[i-1].SkinId)	--SkinId string	??????ID
	  	--????????????
	  	self.baseBlueInfo[i]:Find("IconMask/Icon/Image/HeroName"):GetComponent(Text).text = Data.RolesData[tostring(dataSelf[i-1].RoleId)].Name
	  	
	  	--????????????
	  	self.baseBlueInfo[i]:Find("PlayerName"):GetComponent(Text).text = dataSelf[i-1].PlayerName		--PlayerName	string	????????????
	  	if dataSelf[i-1].PlayerName == Data.PlayerData.Name then
	  		self.baseBlueInfo[i]:Find("PlayerName"):GetComponent(Text).color = Color.New(243/255,212/255,69/255,1)
	  		self.baseBlueInfo[i].parent:Find("Image").gameObject:SetActive(true)
	  	end

	  	--???????????????
	  	self.kdaBluePanel[i]:Find("Image"):GetComponent(Image).sprite = UITools.GetSprite("playerskillicon",Data.SkillsData[tostring(dataSelf[i-1].ZSkillId)].Icon)		--ZSkillId	number  ???????????????ID
  end
  end
end

function BattleInfoController:InitEnemyInfo(dataEnemy,enemyNum)
  --??????Icon
  if enemyNum ~= 0 then
  for i = 1,enemyNum do

  		self.baseRedInfo[i].parent:Find("Image").gameObject:SetActive(false)

	  	self.baseRedInfo[i]:Find("IconMask/Icon"):GetComponent(Image).sprite = UITools.GetSprite("roleicon",dataEnemy[i-1].SkinId)	--SkinId string	??????ID
	  	--????????????

	  	self.baseRedInfo[i]:Find("IconMask/Icon/Image/HeroName"):GetComponent(Text).text = Data.RolesData[tostring(dataEnemy[i-1].RoleId)].Name
	  	
	  	--????????????
	  	self.baseRedInfo[i]:Find("PlayerName"):GetComponent(Text).text = dataEnemy[i-1].PlayerName		--PlayerName	string	????????????
	  	if dataEnemy[i-1].PlayerName == Data.PlayerData.Name then
	  		self.baseRedInfo[i]:Find("PlayerName"):GetComponent(Text).color = Color.New(243/255,212/255,69/255,1)
	  		self.baseRedInfo[i].parent:Find("Image").gameObject:SetActive(true)
	  	end

	  	--???????????????
	  	self.kdaRedPanel[i]:Find("Image"):GetComponent(Image).sprite = UITools.GetSprite("playerskillicon",Data.SkillsData[tostring(dataEnemy[i-1].ZSkillId)].Icon)		--ZSkillId	number  ???????????????ID
  end
  end
end

function BattleInfoController:UpdateSelfInfo(dataSelf,selfNum)
  --??????Icon

  if self.isReceiveData == true then
  	if selfNum ~= 0 then
	  for i = 1,selfNum do
		  	--????????????
		  	self.blueHeroLevel[i]:GetComponent(Text).text = dataSelf[i-1].Level		--Level	number	??????
		  	--????????????	
		  	if dataSelf[i-1].DeadCount ~= 0 then		--DeadCount  number	 ???????????????
		  		self.blueHeroDeadCount[i].parent:GetComponent(Image).color = Color.New(0.37,0.37,0.37,1)
		  		self.blueHeroDeadCount[i].gameObject:SetActive(true)
		  		self.blueHeroDeadCount[i]:GetComponent(Text).text = dataSelf[i-1].DeadCount
		  	else
		  		self.blueHeroDeadCount[i].parent:GetComponent(Image).color = Color.New(1,1,1,1)
		  		self.blueHeroDeadCount[i].gameObject:SetActive(false)
		  	end

		  	--?????????????????????CD
		  	if dataSelf[i-1].CDCount ~= 0 then	--CDCount  number  ??????????????????????????????
		  		self.blueCDCount[i].parent:GetComponent(Image).color = Color.New(0.37,0.37,0.37,1)
		  		self.blueCDCount[i].gameObject:SetActive(true)
		  		self.blueCDCount[i]:GetComponent(Text).text = dataSelf[i-1].CDCount
		  		--??????CD??????
		  	else
		  		self.blueCDCount[i].parent:GetComponent(Image).color = Color.New(1,1,1,1)  
		  		self.blueCDCount[i].gameObject:SetActive(false)	  		
		  	end
		  	--K
		  	self.blueKillNum[i]:GetComponent(Text).text = dataSelf[i-1].Kill	--Kill   number   ?????????
		  	--D
		  	self.blueDeadNum[i]:GetComponent(Text).text = dataSelf[i-1].Dead    --Dead   number   ?????????
		  	--A
		  	self.blueAsNum[i]:GetComponent(Text).text = dataSelf[i-1].Assistant		--Assistant   number   ?????????
		  	--??????
		  	self.blueMoneyNum[i]:GetComponent(Text).text = dataSelf[i-1].Money		--Money   number    ?????????

		  	--??????
		  	self.blueHp[i]:GetComponent(Text).text = dataSelf[i-1].Hp		--Hp   number    ??????

		  	--???????????????
		  	self.bluePAtk[i]:GetComponent(Text).text = dataSelf[i-1].PAtk		--PAtk   number    ???????????????

		  	--????????????
		  	self.blueMAtk[i]:GetComponent(Text).text = dataSelf[i-1].MAtk		--MAtk   number     ????????????

		  	--???????????????
		  	self.bluePDef[i]:GetComponent(Text).text = dataSelf[i-1].PDef        --PDef   number    ???????????????

		  	--???????????????
		  	self.blueMDef[i]:GetComponent(Text).text = dataSelf[i-1].MDef		--MDef    number	???????????????

		  	if dataSelf[i-1].Equips.Length > 0 then
			  	for k = 1,dataSelf[i-1].Equips.Length do
			  		--print(dataSelf[i-1].Equips[k-1])
			  		self.blueEquips[i][k]:GetComponent(Image).sprite = UITools.GetSprite("equipicon",Data.EquipsData[tostring(dataSelf[i-1].Equips[k-1])].Icon)
			  	end	
		  	end	  	
		end
	end
	end
end

function BattleInfoController:UpdateEnemyInfo(dataEnemy,enemyNum)
  --??????Icon
  if self.isReceiveData == true then
  	if enemyNum ~= 0 then
	  for i = 1,enemyNum do
	  		--????????????
		  	self.redHeroLevel[i]:GetComponent(Text).text = dataEnemy[i-1].Level		--Level	number	??????
		  	--????????????	
		  	if dataEnemy[i-1].DeadCount ~= 0 then		--DeadCount  number	 ???????????????
		  		self.redHeroDeadCount[i].parent:GetComponent(Image).color = Color.New(0.37,0.37,0.37,1)
		  		self.redHeroDeadCount[i].gameObject:SetActive(true)
		  		self.redHeroDeadCount[i]:GetComponent(Text).text = dataEnemy[i-1].DeadCount
		  	else
		  		self.redHeroDeadCount[i].parent:GetComponent(Image).color = Color.New(1,1,1,1)
		  		self.redHeroDeadCount[i].gameObject:SetActive(false)
		  	end

		  	--?????????????????????CD
		  	if dataEnemy[i-1].CDCount ~= 0 then	--CDCount  number  ??????????????????????????????
		  		self.redCDCount[i].parent:GetComponent(Image).color = Color.New(0.37,0.37,0.37,1)
		  		self.redCDCount[i].gameObject:SetActive(true)
		  		self.redCDCount[i]:GetComponent(Text).text = dataEnemy[i-1].CDCount
		  		--??????CD??????
		  	else
		  		self.redCDCount[i].parent:GetComponent(Image).color = Color.New(1,1,1,1)  
		  		self.redCDCount[i].gameObject:SetActive(false)	  		
		  	end
		  	--K
		  	self.redKillNum[i]:GetComponent(Text).text = dataEnemy[i-1].Kill	--Kill   number   ?????????
		  	--D
		  	self.redDeadNum[i]:GetComponent(Text).text = dataEnemy[i-1].Dead    --Dead   number   ?????????
		  	--A
		  	self.redAsNum[i]:GetComponent(Text).text = dataEnemy[i-1].Assistant		--Assistant   number   ?????????
		  	--??????
		  	self.redMoneyNum[i]:GetComponent(Text).text = dataEnemy[i-1].Money		--Money   number    ?????????

		  	--??????
		  	self.redHp[i]:GetComponent(Text).text = dataEnemy[i-1].Hp		--Hp   number    ??????

		  	--???????????????
		  	self.redPAtk[i]:GetComponent(Text).text = dataEnemy[i-1].PAtk		--PAtk   number    ???????????????

		  	--????????????
		  	self.redMAtk[i]:GetComponent(Text).text = dataEnemy[i-1].MAtk		--MAtk   number     ????????????

		  	--???????????????
		  	self.redPDef[i]:GetComponent(Text).text = dataEnemy[i-1].PDef        --PDef   number    ???????????????

		  	--???????????????
		  	self.redMDef[i]:GetComponent(Text).text = dataEnemy[i-1].MDef		--MDef    number	???????????????

		  	if dataEnemy[i-1].Equips.Length > 0 then
			  	for k = 1,dataEnemy[i-1].Equips.Length do
			  		--print(dataEnemy[i-1].Equips[k-1])
			  		self.redEquips[i][k]:GetComponent(Image).sprite = UITools.GetSprite("equipicon", Data.EquipsData[tostring(dataEnemy[i-1].Equips[k-1])].Icon)
			  	end
			end
		end
	end
	end
end



function BattleInfoController:OpenControl()
	-- body
	
	if self.delegate ~= nil then
		self.this:InvokeDelegate(self.delegate)
		self.isReceiveData = true
	end
	coroutine.wait(0.01)
	self.this.transform.parent.localPosition = Vector3.New(0,0,0)
	self:TabControl(1)
	coroutine.stop(self.OpenInit)
end

function BattleInfoController:DoOpenControl()
	-- body
	self.this.transform.parent.gameObject:SetActive(true)
	self.OpenInit = coroutine.start(BattleInfoController.OpenControl, self)
end

function BattleInfoController:OpenPanelReceiveData(delegate)
	-- body
	self.delegate = delegate

	self.cor = coroutine.start(BattleInfoController.InitAllInfo, self)	
end

function BattleInfoController:InitAllInfo()
	-- body
	local count = 0 
	while count < 1 do
		if self.delegate ~= nil then
			self.this:InvokeDelegate(self.delegate)
		end
		self.isReceiveData = true
		count = count + 1
		coroutine.wait(0.2)
	end
	self.isReceiveData = false
	coroutine.stop(self.cor)


end

function BattleInfoController:ClosePanelDontReceive(delegate)
	-- body
	self.closeDelegate = delegate
	if self.closeDelegate ~= nil then
		self.this:InvokeDelegate(self.closeDelegate)
	end
end


function BattleInfoController:OnDestroy()
	-- body
	self.this = nil
	self = nil
end
  
