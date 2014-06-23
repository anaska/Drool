<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Drool.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <br />
    <br />
    <br />
    <br />
    <h3>Currencies Info:</h3>
    <div class="table-responsive">
        <table class="table table-striped">
            <thead>
                <tr>
                  <th>Currency</th>
                  <th>Symbol</th>
                  <th>Factor (<a href="#SDR">Special Drawing Rights</a> per currency unit)</th>
                  <th>Update Date</th>
                  <th>Factor Source</th>
                  <th>Significant Figures</th>
                  <th>Smallest Currency Unit</th>
                </tr>
              </thead>
              <asp:Repeater ID="repRecs" runat="server">
                  <ItemTemplate>
                      
                      <tr>
                          <td><%# Eval("CurrencyName") %></td>
                          <td><%# Eval("CurrencySymbol") %></td>
                          <td><%# Eval("SDRFactor") %></td>
                          <td><%# Eval("UpdateDate") %></td>
                          <td><%# Eval("FactorSource") %></td>
                          <td><%# Eval("SigFig") %></td>
                          <td><%# Eval("SmallUnit") %></td>
                      </tr>
                  </ItemTemplate>
              </asp:Repeater>
        </table>
            </div>
    <div class="jumbotron">
        <p id="SDR">The value of the U.S. dollar in terms of the SDR is the reciprocal of the sum of the dollar values, based on market exchange rates, of specified quantities of the first four currencies shown. See SDR Valuation. The value in terms of the SDR of each of the other currencies shown above is derived from that currency's representative exchange rate against the U.S. dollar as reported by the issuing central bank and the SDR value of the U.S. dollar, except for the Iranian rial and the Libyan dinar, the values of which are officially expressed directly in terms of domestic currency units per SDR. All figures are rounded to six significant digits. See Representative Exchange Rates for Selected Currencies.</p>
    </div>
</asp:Content>